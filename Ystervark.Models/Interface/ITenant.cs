namespace Ystervark.Models.Interface
{
    /// <summary>
    /// Tenant Interface
    /// </summary>
    public interface ITenant
    {
        /// <summary>
        /// Gets or sets the tenant identifier.
        /// </summary>
        /// <value>
        /// The tenant identifier.
        /// </value>
        int TenantId { get; set; }
    }
}