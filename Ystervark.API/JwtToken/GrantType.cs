namespace Ystervark.API.JwtToken
{
    /// <summary>
    /// Grant Type Structure 
    /// </summary>
    public struct GrantType
    {
        /// <summary>
        /// The password
        /// </summary>
        public const string Password = "password";

        /// <summary>
        /// The refresh token
        /// </summary>
        public const string RefreshToken = "refresh_token";
    }
}