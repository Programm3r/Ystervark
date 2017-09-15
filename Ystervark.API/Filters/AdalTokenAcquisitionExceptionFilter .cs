using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace Ystervark.API.Filters
{
    /// <summary>
    /// ADAL Token Acquisition Exception Filter Class
    /// </summary>
    /// <seealso cref="ExceptionFilterAttribute" />
    public class AdalTokenAcquisitionExceptionFilter : ExceptionFilterAttribute
    {
        /// <summary>
        /// </summary>
        /// <param name="context"></param>
        /// <inheritdoc />
        public override void OnException(ExceptionContext context)
        {
            //If ADAL failed to acquire access token
            if (context.Exception is AdalSilentTokenAcquisitionException)
            {
                //Send user to Azure AD to re-authenticate
                context.Result = new ChallengeResult();
            }
        }
    }
}