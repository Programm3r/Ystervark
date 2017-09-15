using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class ApprovalConfig
    {
        public ApprovalConfig()
        {
            ApprovalRecipient = new HashSet<ApprovalRecipient>();
            TaskHeader = new HashSet<TaskHeader>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string EntityType { get; set; }
        public int ApprovalStatusId { get; set; }
        public int TenantId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

        public ApprovalStatus ApprovalStatus { get; set; }
        public Resource CreatedByNavigation { get; set; }
        public Tenant Tenant { get; set; }
        public Resource UpdatedByNavigation { get; set; }
        public ICollection<ApprovalRecipient> ApprovalRecipient { get; set; }
        public ICollection<TaskHeader> TaskHeader { get; set; }
    }
}
