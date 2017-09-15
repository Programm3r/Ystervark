using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Booking
    {
        public Booking()
        {
            TagBooking = new HashSet<TagBooking>();
        }

        public int Id { get; set; }
        public int ResourceId { get; set; }
        public int? ProjectId { get; set; }
        public int? ProjectMilestoneId { get; set; }
        public int? ProjectMilestoneTaskId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public TimeSpan Hours { get; set; }
        public int? TeamLeadId { get; set; }
        public string Description { get; set; }
        public int? BookerId { get; set; }
        public int TenantId { get; set; }
        public bool? NonWorkingIncluded { get; set; }

        public Resource Booker { get; set; }
        public Project Project { get; set; }
        public ProjectMilestone ProjectMilestone { get; set; }
        public ProjectMilestoneTask ProjectMilestoneTask { get; set; }
        public Resource Resource { get; set; }
        public Tenant Tenant { get; set; }
        public ICollection<TagBooking> TagBooking { get; set; }
    }
}
