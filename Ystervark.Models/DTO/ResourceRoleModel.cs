namespace Ystervark.Models.DTO
{
    /// <summary>
    /// Resource Role Model Class
    /// </summary>
    public class ResourceRoleModel
    {
        /// <summary>
        /// Gets or sets the resource role identifier.
        /// </summary>
        /// <value>
        /// The resource role identifier.
        /// </value>
        public int ResourceRoleId { get; set; }

        /// <summary>
        /// Gets or sets the resource identifier.
        /// </summary>
        /// <value>
        /// The resource identifier.
        /// </value>
        public int ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the role identifier.
        /// </summary>
        /// <value>
        /// The role identifier.
        /// </value>
        public int RoleId { get; set; }

        /// <summary>
        /// Gets or sets the role.
        /// </summary>
        /// <value>
        /// The role.
        /// </value>
        public RoleModel Role { get; set; }
    }
}