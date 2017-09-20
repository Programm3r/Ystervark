namespace Ystervark.Models.DTO.Base.Client
{
    /// <summary>
    /// Client Model Class Declaration
    /// </summary>
    public abstract class ClientBaseModel : BaseModel
    {
        /// <summary>
        /// Gets or sets the account number.
        /// </summary>
        /// <value>
        /// The account number.
        /// </value>
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ClientModel"/> is archived.
        /// </summary>
        /// <value>
        ///   <c>true</c> if archived; otherwise, <c>false</c>.
        /// </value>
        public bool Archived { get; set; }

        /// <summary>
        /// Gets or sets the client manager identifier.
        /// </summary>
        /// <value>
        /// The client manager identifier.
        /// </value>
        public int? ClientManagerId { get; set; }

        /// <summary>
        /// Gets or sets the name of the client.
        /// </summary>
        /// <value>
        /// The name of the client.
        /// </value>
        public string ClientName { get; set; }

        /// <summary>
        /// Gets or sets the company reg number.
        /// </summary>
        /// <value>
        /// The company reg number.
        /// </value>
        public string CompanyRegNumber { get; set; }

        /// <summary>
        /// Gets or sets the image URL.
        /// </summary>
        /// <value>
        /// The image URL.
        /// </value>
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the region identifier.
        /// </summary>
        /// <value>
        /// The region identifier.
        /// </value>
        public int? RegionId { get; set; }

        /// <summary>
        /// Gets or sets the tenant identifier.
        /// </summary>
        /// <value>
        /// The tenant identifier.
        /// </value>
        public int TenantId { get; set; }

        /// <summary>
        /// Gets or sets the name of the trading as.
        /// </summary>
        /// <value>
        /// The name of the trading as.
        /// </value>
        public string TradingAsName { get; set; }

        /// <summary>
        /// Gets or sets the vat number.
        /// </summary>
        /// <value>
        /// The vat number.
        /// </value>
        public string VATNumber { get; set; }
    }
}