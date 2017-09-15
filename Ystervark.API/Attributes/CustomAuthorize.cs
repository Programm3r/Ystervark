using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;

namespace Ystervark.API.Attributes
{
    /// <summary>
    /// Custom Authorize Attribute Class
    /// </summary>
    /// <seealso cref="AuthorizeAttribute" />
    public class CustomAuthorize : AuthorizeAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAuthorize"/> class.
        /// </summary>
        public CustomAuthorize()
        {
            base.AuthenticationSchemes = string.Join(",",
                CookieAuthenticationDefaults.AuthenticationScheme,
                JwtBearerDefaults.AuthenticationScheme,
                OpenIdConnectDefaults.AuthenticationScheme);
        }
    }
}