using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Task
    {
        public long TaskId { get; set; }
        public string Comments { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime ModifiedData { get; set; }
        public int? CommentUserId { get; set; }
        public int ApprovalStatusId { get; set; }
        public string EntityType { get; set; }
        public int EntityId { get; set; }
        public int TenantId { get; set; }
        public int AssignedTo { get; set; }
        public int RequestedBy { get; set; }
        public int? PriorityId { get; set; }
        public DateTime? DueDate { get; set; }
        public int? ApprovalConfigId { get; set; }
        public bool? IgnoreApprovalConfig { get; set; }

        public ApprovalStatus ApprovalStatus { get; set; }
        public Resource AssignedToNavigation { get; set; }
        public Resource CommentUser { get; set; }
        public Priority Priority { get; set; }
        public Resource RequestedByNavigation { get; set; }
        public Tenant Tenant { get; set; }
    }
}
