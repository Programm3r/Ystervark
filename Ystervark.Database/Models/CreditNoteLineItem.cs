using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class CreditNoteLineItem
    {
        public int Id { get; set; }
        public int CreditNoteLineId { get; set; }
        public int InvoiceLineItemId { get; set; }
        public string Description { get; set; }
        public decimal Qty { get; set; }
        public decimal Amount { get; set; }
        public bool? NoVatApplicable { get; set; }

        public CreditNoteLine CreditNoteLine { get; set; }
        public InvoiceLineItem InvoiceLineItem { get; set; }
    }
}
