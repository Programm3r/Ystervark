using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Comment
    {
        public Comment()
        {
            OpportunityComment = new HashSet<OpportunityComment>();
            ProjectComment = new HashSet<ProjectComment>();
        }

        public int Id { get; set; }
        public string Text { get; set; }
        public int ResourceId { get; set; }
        public int TenantId { get; set; }
        public DateTime PostedOn { get; set; }

        public Resource Resource { get; set; }
        public Tenant Tenant { get; set; }
        public ICollection<OpportunityComment> OpportunityComment { get; set; }
        public ICollection<ProjectComment> ProjectComment { get; set; }
    }
}
