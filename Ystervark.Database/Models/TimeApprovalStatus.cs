using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class TimeApprovalStatus
    {
        public long TimeApprovalStatusId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
