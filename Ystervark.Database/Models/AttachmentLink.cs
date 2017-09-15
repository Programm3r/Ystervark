using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class AttachmentLink
    {
        public int Id { get; set; }
        public int AttachmentId { get; set; }
        public int? OpportunityId { get; set; }
        public int? QuoteId { get; set; }
        public int? ProjectId { get; set; }
        public int? ExpenseId { get; set; }
        public DateTime? InsertDate { get; set; }

        public Attachment Attachment { get; set; }
        public Expense Expense { get; set; }
        public Opportunity Opportunity { get; set; }
        public Project Project { get; set; }
        public Quote Quote { get; set; }
    }
}
