using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Time
    {
        public Time()
        {
            InvoiceLineItemTime = new HashSet<InvoiceLineItemTime>();
        }

        public int TimeId { get; set; }
        public string Description { get; set; }
        public decimal Hours { get; set; }
        public int ProjectId { get; set; }
        public DateTime Date { get; set; }
        public int ResourceId { get; set; }
        public bool? TravelledToClient { get; set; }
        public int? TimeBilled { get; set; }
        public DateTime? DateInserted { get; set; }
        public DateTime? DateBilled { get; set; }
        public bool? ProjectComplete { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int TenantId { get; set; }
        public int? ProjectMilestoneId { get; set; }
        public int? ProjectMilestoneTaskId { get; set; }
        public int? ManagerId { get; set; }

        public Project Project { get; set; }
        public ProjectMilestone ProjectMilestone { get; set; }
        public ProjectMilestoneTask ProjectMilestoneTask { get; set; }
        public Resource Resource { get; set; }
        public Tenant Tenant { get; set; }
        public NonBillableTime NonBillableTime { get; set; }
        public ICollection<InvoiceLineItemTime> InvoiceLineItemTime { get; set; }
    }
}
