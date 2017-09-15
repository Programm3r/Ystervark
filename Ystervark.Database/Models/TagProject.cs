using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class TagProject
    {
        public int ProjectTagId { get; set; }
        public int TagId { get; set; }
        public int ProjectId { get; set; }

        public Project Project { get; set; }
        public Tag Tag { get; set; }
    }
}
