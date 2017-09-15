using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class QuoteLineItem
    {
        public QuoteLineItem()
        {
            ProjectMilestoneTask = new HashSet<ProjectMilestoneTask>();
        }

        public int QuoteLineItemId { get; set; }
        public int QuoteLineId { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
        public int ResourceTypeId { get; set; }
        public decimal Rate { get; set; }

        public QuoteLine QuoteLine { get; set; }
        public ResourceType ResourceType { get; set; }
        public ICollection<ProjectMilestoneTask> ProjectMilestoneTask { get; set; }
    }
}
