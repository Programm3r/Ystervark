using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Role
    {
        public Role()
        {
            ApprovalRecipient = new HashSet<ApprovalRecipient>();
            ResourceRole = new HashSet<ResourceRole>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDisplayName { get; set; }
        public string Description { get; set; }

        public ICollection<ApprovalRecipient> ApprovalRecipient { get; set; }
        public ICollection<ResourceRole> ResourceRole { get; set; }
    }
}
