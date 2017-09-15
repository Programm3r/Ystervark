using System.ComponentModel.DataAnnotations.Schema;

namespace Ystervark.API.JwtToken
{
    /// <summary>
    /// Token Response Class
    /// </summary>
    public class TokenResponse
    {
        /// <summary>
        /// Gets or sets the access token.
        /// </summary>
        /// <value>
        /// The access token.
        /// </value>
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or sets the expires in.
        /// </summary>
        /// <value>
        /// The expires in.
        /// </value>
        public int ExpiresIn { get; set; }

        /// <summary>
        /// Gets or sets the is stop.
        /// </summary>
        /// <value>
        /// The is stop.
        /// </value>
        public int IsStop { get; set; }

        /// <summary>
        /// Gets or sets the refresh token.
        /// </summary>
        /// <value>
        /// The refresh token.
        /// </value>
        public string RefreshToken { get; set; }

        /// <summary>
        /// Gets or sets the type of the token.
        /// </summary>
        /// <value>
        /// The type of the token.
        /// </value>
        public string TokenType { get; set; }
    }
}