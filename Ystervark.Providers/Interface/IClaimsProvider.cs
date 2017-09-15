using System.Collections.Generic;
using System.Security.Claims;
using Ystervark.Models.DTO;

namespace Ystervark.Providers.Interface
{
    /// <summary>
    /// Claims Provider Interface
    /// </summary>
    public interface IClaimsProvider
    {
        /// <summary>
        /// Gets the claims by resource data.
        /// </summary>
        /// <param name="resource">The resource.</param>
        /// <returns></returns>
        IEnumerable<Claim> GetClaimsByResourceData(ResourceModel resource);
    }
}