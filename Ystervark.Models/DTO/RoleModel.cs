using Ystervark.Models.DTO.Base;

namespace Ystervark.Models.DTO
{
    /// <summary>
    /// Role Model Class
    /// </summary>
    /// <seealso cref="Ystervark.Models.DTO.Base.BaseModel" />
    public class RoleModel : BaseModel
    {
        /// <summary>
        /// Gets or sets the role identifier.
        /// </summary>
        /// <value>
        /// The role identifier.
        /// </value>
        public int RoleId { get; set; }

        /// <summary>
        /// Gets or sets the name of the role.
        /// </summary>
        /// <value>
        /// The name of the role.
        /// </value>
        public string RoleName { get; set; }

        /// <summary>
        /// Gets or sets the display name of the role.
        /// </summary>
        /// <value>
        /// The display name of the role.
        /// </value>
        public string RoleDisplayName { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }
    }
}