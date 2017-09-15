using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class ProjectComment
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int CommentId { get; set; }

        public Comment Comment { get; set; }
        public Project Project { get; set; }
    }
}
