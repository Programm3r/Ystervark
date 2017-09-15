using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class TimesheetTimer
    {
        public int Id { get; set; }
        public int ResourceId { get; set; }
        public int ClientId { get; set; }
        public int ProjectId { get; set; }
        public int? MilestoneId { get; set; }
        public int? MilestoneTaskId { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public double? Hours { get; set; }
        public bool? IsResourceTask { get; set; }
    }
}
