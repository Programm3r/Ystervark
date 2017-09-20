using Ystervark.Models.DTO.Base.Client;

namespace Ystervark.Models.DTO
{
    /// <summary>
    /// Client Summary Model Class
    /// </summary>
    /// <seealso cref="ClientBaseModel" />
    public class ClientSummaryModel : ClientBaseModel
    {
        /// <summary>
        /// Gets or sets the client manager email.
        /// </summary>
        /// <value>
        /// The client manager email.
        /// </value>
        public string ClientManagerEmail { get; set; }

        /// <summary>
        /// Gets or sets the full name of the client manager.
        /// </summary>
        /// <value>
        /// The full name of the client manager.
        /// </value>
        public string ClientManagerFullName { get; set; }

        /// <summary>
        /// Gets or sets the client manager image URL.
        /// </summary>
        /// <value>
        /// The client manager image URL.
        /// </value>
        public string ClientManagerImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the client manager phone.
        /// </summary>
        /// <value>
        /// The client manager phone.
        /// </value>
        public string ClientManagerPhone { get; set; }
        /// <summary>
        /// Gets or sets the primary contact business phone.
        /// </summary>
        /// <value>
        /// The primary contact business phone.
        /// </value>
        public string PrimaryContactBusinessPhone { get; set; }

        /// <summary>
        /// Gets or sets the primary contact email.
        /// </summary>
        /// <value>
        /// The primary contact email.
        /// </value>
        public string PrimaryContactEmail { get; set; }

        /// <summary>
        /// Gets or sets the full name of the primary contact.
        /// </summary>
        /// <value>
        /// The full name of the primary contact.
        /// </value>
        public string PrimaryContactFullName { get; set; }

        /// <summary>
        /// Gets or sets the projects active.
        /// </summary>
        /// <value>
        /// The projects active.
        /// </value>
        public int ProjectsActive { get; set; }

        /// <summary>
        /// Gets or sets the projects archived.
        /// </summary>
        /// <value>
        /// The projects archived.
        /// </value>
        public int ProjectsArchived { get; set; }
    }
}