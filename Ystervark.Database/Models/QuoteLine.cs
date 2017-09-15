using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class QuoteLine
    {
        public QuoteLine()
        {
            ProjectMilestone = new HashSet<ProjectMilestone>();
            QuoteLineItem = new HashSet<QuoteLineItem>();
            QuoteLineItemMisc = new HashSet<QuoteLineItemMisc>();
        }

        public int QuoteLineId { get; set; }
        public int QuoteId { get; set; }
        public string Description { get; set; }

        public Quote Quote { get; set; }
        public ICollection<ProjectMilestone> ProjectMilestone { get; set; }
        public ICollection<QuoteLineItem> QuoteLineItem { get; set; }
        public ICollection<QuoteLineItemMisc> QuoteLineItemMisc { get; set; }
    }
}
