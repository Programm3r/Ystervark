using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Ystervark.API.Controllers.Base;
using Ystervark.API.JwtToken;
using Ystervark.Manager.Interface;
using Ystervark.Models.DTO;
using Ystervark.Models.Helper;
using Ystervark.Providers.Interface;

namespace Ystervark.API.Controllers
{
    /// <summary>
    /// Authentication Controller Class
    /// </summary>
    /// <seealso cref="BaseController{IResourceManager}" />
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class AuthenticationController : BaseController<IResourceManager>
    {
        /// <summary>
        /// The claims provider
        /// </summary>
        private readonly IClaimsProvider _claimsProvider;

        /// <summary>
        /// Gets the options.
        /// </summary>
        /// <value>
        /// The options.
        /// </value>
        private TokenOptions Options { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationController" /> class.
        /// </summary>
        /// <param name="resourceManager">The resource manager.</param>
        /// <param name="options">The options.</param>
        /// <param name="claimsProvider">The claims provider.</param>
        public AuthenticationController(IResourceManager resourceManager, IOptions<TokenOptions> options, IClaimsProvider claimsProvider) 
            : base(resourceManager)
        {
            this._claimsProvider = claimsProvider;
            this.Options = options.Value;
        }

        /// <summary>
        /// Gets the token.
        /// </summary>
        /// <param name="resource">The resource.</param>
        /// <returns></returns>
        private JwtSecurityToken GetToken(ResourceModel resource)
        {
            // create the JWT
            return new JwtSecurityToken(
                audience: this.Options.Audience,
                issuer: this.Options.Issuer,
                expires: this.Options.GetExpiration(),
                claims: this._claimsProvider.GetClaimsByResourceData(resource),
                signingCredentials: this.Options.GetSigningCredentials());
        }

        /// <summary>
        /// Gets the resource by credentials.
        /// </summary>
        /// <returns></returns>
        private async Task<IActionResult> GetResourceByCredentials(TokenRequest request)
        {
            var resource = await base.Manager.AuthenticateResource(request.Username, request.Password);
            if (resource == null)
            {
                return base.Unauthorized();
            }
            
            // TODO: persist the JWT to storage
            return base.Ok(new TokenResponse
            {
                TokenType = this.Options.Type,
                AccessToken = new JwtSecurityTokenHandler().WriteToken(this.GetToken(resource)),
                ExpiresIn = (int)this.Options.ValidFor.TotalSeconds,
                RefreshToken = this.Options.GetRefreshToken(),
                IsStop = 0
            });
        }

        /// <summary>
        /// Refreshes the token.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        private async Task<IActionResult> RefreshToken(TokenRequest request)
        {
            // TODO: get token from storage, based of value presented in refresh_token
            // TODO: expire the old refresh_token and add a new refresh_token
            // TODO: get user associated with the refresh_token
            var resource = new ResourceModel();
            return base.Ok(new TokenResponse
            {
                TokenType = this.Options.Type,
                AccessToken = new JwtSecurityTokenHandler().WriteToken(this.GetToken(resource)),
                ExpiresIn = (int)this.Options.ValidFor.TotalSeconds,
                RefreshToken = this.Options.GetRefreshToken(),
                IsStop = 0
            });
        }

        /// <summary>
        /// Tokens the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        [HttpPost("[action]")]
        [AllowAnonymous]
        public async Task<IActionResult> Token([FromBody]TokenRequest request)
        {
            switch (request.GrantType)
            {
                case GrantType.Password:
                    return await this.GetResourceByCredentials(request);
                case GrantType.RefreshToken:
                    return await this.RefreshToken(request);
                default:
                    return base.BadRequest();
            }            
        }
    }
}