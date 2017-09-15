namespace Ystervark.Models.Enums
{
    /// <summary>
    /// Authorize Policy Names Class
    /// </summary>
    public struct AuthorizePolicy
    {
        /// <summary>
        /// The administrator
        /// </summary>
        public const string Administrator = "Admin";

        /// <summary>
        /// The billing administrator
        /// </summary>
        public const string BillingAdministrator = "BillingAdministrator";

        /// <summary>
        /// The client manager
        /// </summary>
        public const string ClientManager = "ClientManager";

        /// <summary>
        /// The project manager
        /// </summary>
        public const string ProjectManager = "ProjectManager";

        /// <summary>
        /// The managers
        /// </summary>
        public const string Managers = "Managers";

        /// <summary>
        /// The administrative managers
        /// </summary>
        public const string AdministrativeManagers = "AdministrativeManagers";
    }
}