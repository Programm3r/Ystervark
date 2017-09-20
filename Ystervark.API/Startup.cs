using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using Autofac;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Swashbuckle.AspNetCore.Swagger;
using Ystervark.API.Attributes;
using Ystervark.API.Extensions;
using Ystervark.API.Middleware;
using Ystervark.API.Services;
using Ystervark.Database.Models;
using Ystervark.Instant;
using Ystervark.IoC;
using Ystervark.Manager.Interface;
using Ystervark.Models.Enums;
using Contact = Swashbuckle.AspNetCore.Swagger.Contact;

namespace Ystervark.API
{
    /// <summary>
    /// Start-Up Class
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Startup"/> class.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// Gets the configuration.
        /// </summary>
        /// <value>
        /// The configuration.
        /// </value>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Configures the services.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <remarks>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </remarks>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Briteplan>(options => options.UseSqlServer(Configuration["Data:ConnectionStrings:BloggingDatabase"]));

            services.AddAuthorization(ConfigureAuthPolicies());

            services.AddSingleton<IAuthorizationHandler, CheckUserRoleHandler>();

            services.AddAuthentication(auth =>
            {
                auth.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                auth.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                auth.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
                auth.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddBpJwtBearer(options => Configuration.Bind("TokenOptions", options))
            .AddCookie().AddOpenIdConnect(opts =>
            {
                Configuration.GetSection("Authentication").Bind(opts);

                opts.Events = new OpenIdConnectEvents
                {
                    OnAuthorizationCodeReceived = async ctx =>
                    {
                        var request = ctx.HttpContext.Request;
                        var currentUri = UriHelper.BuildAbsolute(request.Scheme, request.Host, request.PathBase, request.Path);
                        var credential = new ClientCredential(ctx.Options.ClientId, ctx.Options.ClientSecret);

                        var distributedCache = ctx.HttpContext.RequestServices.GetRequiredService<IDistributedCache>();
                        var userId = ctx.Principal.FindFirst("http://schemas.microsoft.com/identity/claims/objectidentifier").Value;

                        var cache = new AdalDistributedTokenCache(distributedCache, userId);

                        var authContext = new AuthenticationContext(ctx.Options.Authority, cache);

                        var result = await authContext.AcquireTokenByAuthorizationCodeAsync(ctx.ProtocolMessage.Code,
                            new Uri(currentUri),
                            credential,
                            ctx.Options.Resource);

                        var requiredService = ctx.HttpContext.RequestServices.GetRequiredService<IResourceManager>();
                        var resource = await requiredService.GetByUsername(result.UserInfo.DisplayableId);
                        if (resource != null)
                        {
                            var claims = new List<Claim>
                            {
                                new Claim(YstervarkClaimNames.ResourceName, resource.ResourceName),
                                new Claim(YstervarkClaimNames.ResourceId, resource.ResourceId.ToString()),
                                new Claim(YstervarkClaimNames.TenantId, resource.TenantId.ToString()),
                                new Claim(JwtRegisteredClaimNames.Email, resource.Emailaddress),
                            };
                            claims.AddRange(resource.ResourceRole.Select(roleModel =>
                                new Claim(ClaimsIdentity.DefaultRoleClaimType, roleModel.Role.RoleName)));
                            ctx.Principal.AddIdentity(new ClaimsIdentity(claims));
                        }
                        else
                        {
                            ctx.Fail(new UnauthorizedAccessException());
                            return;
                        }

                        ctx.HandleCodeRedemption(result.AccessToken, result.IdToken);
                    }
                };
            });

            services.AddMvc().AddJsonOptions(j =>
            {
                j.SerializerSettings.ContractResolver = new DefaultContractResolver();
                j.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new Info
                    {
                        Title = "Ystervark",
                        Version = "v1",
                        Contact = new Contact
                        {
                            Email = "rga.bailey@gmail.com",
                            Name = "Richard Bailey",
                            Url = "https://github.com/Programm3r"
                        }
                    });
            });

            services.AddSignalR();
        }

        /// <summary>
        /// Configures the authentication policies.
        /// </summary>
        /// <returns></returns>
        private static Action<AuthorizationOptions> ConfigureAuthPolicies()
        {
            return o =>
            {
                o.AddPolicy(AuthorizePolicy.Administrator, policy => policy.Requirements.Add(new RoleRequirement(UserRoles.Administrator)));
                o.AddPolicy(AuthorizePolicy.ClientManager, policy => policy.Requirements.Add(new RoleRequirement(UserRoles.ClientManager)));
                o.AddPolicy(AuthorizePolicy.ProjectManager, policy => policy.Requirements.Add(new RoleRequirement(UserRoles.ProjectManager)));
                o.AddPolicy(AuthorizePolicy.BillingAdministrator, policy => policy.Requirements.Add(new RoleRequirement(UserRoles.BillingAdmin)));
                o.AddPolicy(AuthorizePolicy.AdministrativeManagers,
                    policy =>
                        policy.Requirements.Add(new RoleRequirement(UserRoles.Administrator, UserRoles.ClientManager, UserRoles.ProjectManager)));
                o.AddPolicy(AuthorizePolicy.Managers,
                    policy => policy.Requirements.Add(new RoleRequirement(UserRoles.ClientManager, UserRoles.ProjectManager)));
            };
        }

        /// <summary>
        /// Configures the container.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new DbContextModule());
            builder.RegisterModule(new AutoMapperModule());
            builder.RegisterModule(new ProviderModule());
            builder.RegisterModule(new ManagerModule());
        }

        /// <summary>
        /// Configures the specified application.
        /// </summary>
        /// <param name="app">The application.</param>
        /// <param name="env">The environment.</param>
        /// <param name="loggerFactory">The logger factory.</param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Ystervark");
                c.InjectOnCompleteJavaScript("/swagger-ui/authorization1.js");
                c.ShowJsonEditor();
                c.ShowRequestHeaders();
            });

            app.UseSignalR(action =>
            {
                action.MapHub<Chat>("chat");
            });

            app.UseAuthentication();
            app.UseMiddleware(typeof(ErrorHandlingMiddleware));
            app.UseMvc();
        }
    }
}