using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class TaskHeader
    {
        public int Id { get; set; }
        public int ApprovalStatusId { get; set; }
        public int EntityId { get; set; }
        public string EntityType { get; set; }
        public int? AssigendTo { get; set; }
        public int RequestedBy { get; set; }
        public string Comment { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int TenantId { get; set; }
        public int? PriorityId { get; set; }
        public DateTime? DueDate { get; set; }
        public int? ApprovalConfigId { get; set; }

        public ApprovalConfig ApprovalConfig { get; set; }
        public ApprovalStatus ApprovalStatus { get; set; }
        public Tenant Tenant { get; set; }
    }
}
