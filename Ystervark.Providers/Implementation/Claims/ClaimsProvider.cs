using System;
using System.Collections.Generic;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using Ystervark.Models.DTO;
using Ystervark.Models.Enums;
using Ystervark.Providers.Interface;

namespace Ystervark.Providers.Implementation.Claims
{
    /// <summary>
    /// Claims Provider Class
    /// </summary>
    public class ClaimsProvider : IClaimsProvider
    {
        /// <summary>
        /// Gets the claims by resource data.
        /// </summary>
        /// <param name="resource">The resource.</param>
        /// <returns></returns>
        public IEnumerable<Claim> GetClaimsByResourceData(ResourceModel resource)
        {
            var claims = new List<Claim>();

            if (resource.ResourceRole != null && resource.ResourceRole.Any())
            {
                claims.AddRange(resource.ResourceRole.Select(roleModel => new Claim(ClaimsIdentity.DefaultRoleClaimType, roleModel.Role.RoleName)));
            }
            claims.Add(new Claim(YstervarkClaimNames.ResourceName, resource.ResourceName));
            claims.Add(new Claim(YstervarkClaimNames.ResourceId, resource.ResourceId.ToString()));
            claims.Add(new Claim(YstervarkClaimNames.TenantId, resource.TenantId.ToString()));
            claims.Add(new Claim(JwtRegisteredClaimNames.Email, resource.Emailaddress));
            claims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
            claims.Add(new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToUniversalTime().ToString(CultureInfo.InvariantCulture), ClaimValueTypes.Integer64));

            return claims;
        }
    }
}