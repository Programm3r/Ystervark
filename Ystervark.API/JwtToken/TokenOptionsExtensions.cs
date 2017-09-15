using System;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Ystervark.API.JwtToken
{
    /// <summary>
    /// Token Options Extensions Class
    /// </summary>
    public static class TokenOptionsExtensions
    {
        /// <summary>
        /// Gets the expiration.
        /// </summary>
        /// <param name="options">The options.</param>
        /// <returns></returns>
        public static DateTime GetExpiration(this TokenOptions options) => DateTime.UtcNow.Add(options.ValidFor);

        /// <summary>
        /// Gets the refresh token.
        /// </summary>
        /// <param name="options">The options.</param>
        /// <returns></returns>
        public static string GetRefreshToken(this TokenOptions options) => Guid.NewGuid().ToString().Replace("-", string.Empty);

        /// <summary>
        /// Gets the signing credentials.
        /// </summary>
        /// <param name="options">The options.</param>
        /// <returns></returns>
        public static SigningCredentials GetSigningCredentials(this TokenOptions options) =>
            new SigningCredentials(options.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256);

        /// <summary>
        /// Gets the symmetric security key.
        /// </summary>
        /// <param name="options">The options.</param>
        /// <returns></returns>
        public static SymmetricSecurityKey GetSymmetricSecurityKey(this TokenOptions options) =>
            new SymmetricSecurityKey(options.GetSigningKeyBytes());

        /// <summary>
        /// Gets the signing key bytes.
        /// </summary>
        /// <param name="options">The options.</param>
        /// <returns></returns>
        private static byte[] GetSigningKeyBytes(this TokenOptions options) => Encoding.ASCII.GetBytes(options.SigningKey);
    }
}