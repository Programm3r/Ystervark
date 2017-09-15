using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class ApprovalStatus
    {
        public ApprovalStatus()
        {
            ApprovalConfig = new HashSet<ApprovalConfig>();
            Task = new HashSet<Task>();
            TaskHeader = new HashSet<TaskHeader>();
        }

        public int ApprovalStatusId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<ApprovalConfig> ApprovalConfig { get; set; }
        public ICollection<Task> Task { get; set; }
        public ICollection<TaskHeader> TaskHeader { get; set; }
    }
}
