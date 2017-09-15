using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Ystervark.API.Attributes.Base
{
    /// <summary>
    /// Authorization Handler Base Class
    /// </summary>
    /// <seealso cref="AuthorizationHandler{RoleRequirement}" />
    public abstract class AuthorizationHandlerBase : AuthorizationHandler<RoleRequirement>
    {
        /// <summary>
        /// Makes a decision if authorization is allowed based on a specific requirement.
        /// </summary>
        /// <param name="context">The authorization context.</param>
        /// <param name="requirement">The requirement to evaluate.</param>
        /// <returns></returns>
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, RoleRequirement requirement)
        {
            if (!context.User.HasClaim(c => c.Type == ClaimTypes.Role))
            {
                context.Fail();
                return Task.CompletedTask;
            }

            if (context.User.Claims.Any(c => c.Type == ClaimTypes.Role && requirement.Roles != null && requirement.Roles.Any(f => f == c.Value)))
            {
                context.Succeed(requirement);
                return Task.CompletedTask;
            }

            context.Fail();
            return Task.CompletedTask;
        }
    }
}