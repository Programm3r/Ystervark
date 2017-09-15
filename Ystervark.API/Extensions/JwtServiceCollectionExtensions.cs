using System;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Ystervark.API.JwtToken;

namespace Ystervark.API.Extensions
{
    /// <summary>
    /// JWT Service Collection Extensions Class
    /// </summary>
    public static class JwtServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the BP JWT bearer.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <returns></returns>
        public static AuthenticationBuilder AddBpJwtBearer(this AuthenticationBuilder builder) => builder.AddBpJwtBearer(_ =>
        {
        });

        /// <summary>
        /// Adds the BP JWT bearer.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configure options.</param>
        /// <returns></returns>
        public static AuthenticationBuilder AddBpJwtBearer(this AuthenticationBuilder builder, Action<TokenOptions> configureOptions)
        {
            builder.Services.Configure(configureOptions);
            builder.Services.AddSingleton<IConfigureOptions<JwtBearerOptions>, ConfigureJwtOptions>();
            builder.AddJwtBearer();
            return builder;
        }

        /// <summary>
        /// Configure JWT Options class
        /// </summary>
        /// <seealso cref="IConfigureNamedOptions{JwtBearerOptions}" />
        private class ConfigureJwtOptions : IConfigureNamedOptions<JwtBearerOptions>
        {
            /// <summary>
            /// The JWT options
            /// </summary>
            private readonly TokenOptions _jwtOptions;

            /// <summary>
            /// Initializes a new instance of the <see cref="ConfigureJwtOptions"/> class.
            /// </summary>
            /// <param name="azureOptions">The azure options.</param>
            public ConfigureJwtOptions(IOptions<TokenOptions> azureOptions)
            {
                _jwtOptions = azureOptions.Value;
            }

            /// <summary>
            /// Invoked to configure a TOptions instance.
            /// </summary>
            /// <param name="name">The name of the options instance being configured.</param>
            /// <param name="options">The options instance to configure.</param>
            public void Configure(string name, JwtBearerOptions options)
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidAudience = _jwtOptions.Audience,
                    ValidIssuer = _jwtOptions.Issuer,
                    IssuerSigningKey = _jwtOptions.GetSymmetricSecurityKey()
                };
            }

            /// <summary>
            /// Invoked to configure a TOptions instance.
            /// </summary>
            /// <param name="options">The options instance to configure.</param>
            public void Configure(JwtBearerOptions options)
            {
                Configure(Options.DefaultName, options);
            }
        }
    }
}