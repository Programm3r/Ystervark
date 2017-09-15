using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class InvoiceLineItem
    {
        public InvoiceLineItem()
        {
            CreditNoteLineItem = new HashSet<CreditNoteLineItem>();
            InvoiceLineItemTime = new HashSet<InvoiceLineItemTime>();
        }

        public int Id { get; set; }
        public int InvoiceLineId { get; set; }
        public int? QuoteLineItemMiscId { get; set; }
        public int? ProjectMilestoneTaskId { get; set; }
        public string Description { get; set; }
        public decimal Qty { get; set; }
        public decimal Amount { get; set; }
        public bool? NoVatApplicable { get; set; }

        public InvoiceLine InvoiceLine { get; set; }
        public ProjectMilestoneTask ProjectMilestoneTask { get; set; }
        public QuoteLineItemMisc QuoteLineItemMisc { get; set; }
        public ICollection<CreditNoteLineItem> CreditNoteLineItem { get; set; }
        public ICollection<InvoiceLineItemTime> InvoiceLineItemTime { get; set; }
    }
}
