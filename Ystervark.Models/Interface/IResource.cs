namespace Ystervark.Models.Interface
{
    /// <summary>
    /// Resource Interface Declaration
    /// </summary>
    public interface IResource : ITenant
    {
        /// <summary>
        /// Gets or sets the resource identifier.
        /// </summary>
        /// <value>
        /// The resource identifier.
        /// </value>
        int ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the name of the resource.
        /// </summary>
        /// <value>
        /// The name of the resource.
        /// </value>
        string ResourceName { get; set; }
    }
}