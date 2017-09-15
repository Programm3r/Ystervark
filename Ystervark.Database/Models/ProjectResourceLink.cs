using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class ProjectResourceLink
    {
        public int ProjectResourceLinkId { get; set; }
        public int ProjectId { get; set; }
        public int ResourceId { get; set; }
        public int ApproverId { get; set; }
        public bool? Archived { get; set; }

        public Project Project { get; set; }
        public Resource Resource { get; set; }
    }
}
