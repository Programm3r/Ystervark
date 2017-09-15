using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class CreditNoteLine
    {
        public CreditNoteLine()
        {
            CreditNoteLineItem = new HashSet<CreditNoteLineItem>();
        }

        public int Id { get; set; }
        public int CreditNoteProjectId { get; set; }
        public int InvoiceLineId { get; set; }
        public string Description { get; set; }

        public CreditNoteProject CreditNoteProject { get; set; }
        public InvoiceLine InvoiceLine { get; set; }
        public ICollection<CreditNoteLineItem> CreditNoteLineItem { get; set; }
    }
}
