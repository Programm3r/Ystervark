using System;

namespace Ystervark.API.JwtToken
{
    /// <summary>
    /// Token Options Class
    /// </summary>
    public class TokenOptions
    {
        /// <summary>
        /// Gets or sets the audience.
        /// </summary>
        /// <value>
        /// The audience.
        /// </value>
        public string Audience { get; set; }

        /// <summary>
        /// Gets or sets the issuer.
        /// </summary>
        /// <value>
        /// The issuer.
        /// </value>
        public string Issuer { get; set; }

        /// <summary>
        /// Gets or sets the signing key.
        /// </summary>
        /// <value>
        /// The signing key.
        /// </value>
        public string SigningKey { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public string Type { get; set; } = "Bearer";

        /// <summary>
        /// Gets or sets the valid for.
        /// </summary>
        /// <value>
        /// The valid for.
        /// </value>
        public TimeSpan ValidFor { get; set; } = TimeSpan.FromHours(1);
    }
}