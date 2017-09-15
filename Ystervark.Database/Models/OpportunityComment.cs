using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class OpportunityComment
    {
        public int Id { get; set; }
        public int OpportunityId { get; set; }
        public int CommentId { get; set; }

        public Comment Comment { get; set; }
        public Opportunity Opportunity { get; set; }
    }
}
