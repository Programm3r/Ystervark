using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class ApprovalRecipient
    {
        public int Id { get; set; }
        public int ApprovalConfigId { get; set; }
        public int? ResourceId { get; set; }
        public int? RoleId { get; set; }
        public bool? ResourceInRole { get; set; }
        public bool? IncludeRequester { get; set; }

        public ApprovalConfig ApprovalConfig { get; set; }
        public Resource Resource { get; set; }
        public Role Role { get; set; }
    }
}
