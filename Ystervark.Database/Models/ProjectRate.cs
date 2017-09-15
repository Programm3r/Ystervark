using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class ProjectRate
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int TenantId { get; set; }
        public int ResourceId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public decimal ClientRate { get; set; }
        public int CreatedResourceId { get; set; }
        public int? UpdatedResourceId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public bool? IsActive { get; set; }
        public int? ParentId { get; set; }
        public int? ProjectMilestoneTaskId { get; set; }

        public Project Project { get; set; }
        public ProjectMilestoneTask ProjectMilestoneTask { get; set; }
        public Resource Resource { get; set; }
        public Tenant Tenant { get; set; }
    }
}
