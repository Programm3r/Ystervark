using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace Ystervark.API.Attributes
{
    /// <summary>
    /// Role Requirement Class
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Authorization.IAuthorizationRequirement" />
    public class RoleRequirement : IAuthorizationRequirement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleRequirement"/> class.
        /// </summary>
        /// <param name="roles">The roles.</param>
        public RoleRequirement(params string[] roles)
        {
            Roles = roles;
        }

        /// <summary>
        /// Gets or sets the roles.
        /// </summary>
        /// <value>
        /// The roles.
        /// </value>
        public IEnumerable<string> Roles { get; set; }
    }
}