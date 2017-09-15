using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class ProjectMilestone
    {
        public ProjectMilestone()
        {
            Booking = new HashSet<Booking>();
            InvoiceLine = new HashSet<InvoiceLine>();
            ProjectMilestoneTask = new HashSet<ProjectMilestoneTask>();
            Time = new HashSet<Time>();
        }

        public int ProjectMileStoneId { get; set; }
        public int ProjectId { get; set; }
        public string Description { get; set; }
        public DateTime CompletionDate { get; set; }
        public int? QuoteLineId { get; set; }

        public Project Project { get; set; }
        public QuoteLine QuoteLine { get; set; }
        public ICollection<Booking> Booking { get; set; }
        public ICollection<InvoiceLine> InvoiceLine { get; set; }
        public ICollection<ProjectMilestoneTask> ProjectMilestoneTask { get; set; }
        public ICollection<Time> Time { get; set; }
    }
}
