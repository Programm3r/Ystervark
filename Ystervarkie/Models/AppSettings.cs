namespace Ystervarkie.Models
{
    public class AppSettings
    {
        public bool EnableLogging { get; set; }

        public string LoginUrl { get; set; }

        /// <summary>
        /// Gets or sets the redirect URI.
        /// </summary>
        /// <value>
        /// The redirect URI.
        /// </value>
        public string RedirectUri { get; set; }
    }
}