using System;
using System.Collections.Generic;
using Ystervark.Models.Interface;

namespace Ystervark.Models.DTO
{
    /// <summary>
    /// Resource Model Class
    /// </summary>
    /// <seealso cref="Ystervark.Models.Interface.IResource" />
    public class ResourceModel : IResource
    {
        /// <summary>
        /// Gets or sets the resource identifier.
        /// </summary>
        /// <value>
        /// The resource identifier.
        /// </value>
        public int ResourceId { get; set; }
        /// <summary>
        /// Gets or sets the name of the resource.
        /// </summary>
        /// <value>
        /// The name of the resource.
        /// </value>
        public string ResourceName { get; set; }
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get; set; }
        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }
        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password { get; set; }
        /// <summary>
        /// Gets or sets the emailaddress.
        /// </summary>
        /// <value>
        /// The emailaddress.
        /// </value>
        public string Emailaddress { get; set; }
        /// <summary>
        /// Gets or sets the date inserted.
        /// </summary>
        /// <value>
        /// The date inserted.
        /// </value>
        public DateTime? DateInserted { get; set; }
        /// <summary>
        /// Gets or sets the cell phone nr.
        /// </summary>
        /// <value>
        /// The cell phone nr.
        /// </value>
        public string CellPhoneNr { get; set; }
        /// <summary>
        /// Gets or sets the tenant identifier.
        /// </summary>
        /// <value>
        /// The tenant identifier.
        /// </value>
        public int TenantId { get; set; }
        /// <summary>
        /// Gets or sets the is top level admin.
        /// </summary>
        /// <value>
        /// The is top level admin.
        /// </value>
        public bool? IsTopLevelAdmin { get; set; }
        /// <summary>
        /// Gets or sets the region identifier.
        /// </summary>
        /// <value>
        /// The region identifier.
        /// </value>
        public int? RegionId { get; set; }
        /// <summary>
        /// Gets or sets the client identifier.
        /// </summary>
        /// <value>
        /// The client identifier.
        /// </value>
        public int? ClientId { get; set; }
        /// <summary>
        /// Gets or sets the resource type identifier.
        /// </summary>
        /// <value>
        /// The resource type identifier.
        /// </value>
        public int? ResourceTypeId { get; set; }
        /// <summary>
        /// Gets or sets the physical address identifier.
        /// </summary>
        /// <value>
        /// The physical address identifier.
        /// </value>
        public int? PhysicalAddressId { get; set; }
        /// <summary>
        /// Gets or sets the image URL.
        /// </summary>
        /// <value>
        /// The image URL.
        /// </value>
        public string ImageUrl { get; set; }
        /// <summary>
        /// Gets or sets the bank detail identifier.
        /// </summary>
        /// <value>
        /// The bank detail identifier.
        /// </value>
        public int? BankDetailId { get; set; }
        /// <summary>
        /// Gets or sets the updated by.
        /// </summary>
        /// <value>
        /// The updated by.
        /// </value>
        public int? UpdatedBy { get; set; }
        /// <summary>
        /// Gets or sets the updated on.
        /// </summary>
        /// <value>
        /// The updated on.
        /// </value>
        public DateTime? UpdatedOn { get; set; }

        /// <summary>
        /// Gets or sets the resource role.
        /// </summary>
        /// <value>
        /// The resource role.
        /// </value>
        public IEnumerable<ResourceRoleModel> ResourceRole { get; set; }
    }
}