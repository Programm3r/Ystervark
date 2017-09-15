using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class ProjectMilestoneTask
    {
        public ProjectMilestoneTask()
        {
            Booking = new HashSet<Booking>();
            InvoiceLineItem = new HashSet<InvoiceLineItem>();
            ProjectRate = new HashSet<ProjectRate>();
            Time = new HashSet<Time>();
        }

        public int ProjectMilestoneTaskId { get; set; }
        public int ProjectMilestoneId { get; set; }
        public string TaskDescription { get; set; }
        public int AllocatedHours { get; set; }
        public decimal QuotedRate { get; set; }
        public int? QuoteLineItemId { get; set; }
        public int? HoursPerDayAllocated { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? ResourceId { get; set; }

        public ProjectMilestone ProjectMilestone { get; set; }
        public QuoteLineItem QuoteLineItem { get; set; }
        public Resource Resource { get; set; }
        public ICollection<Booking> Booking { get; set; }
        public ICollection<InvoiceLineItem> InvoiceLineItem { get; set; }
        public ICollection<ProjectRate> ProjectRate { get; set; }
        public ICollection<Time> Time { get; set; }
    }
}
