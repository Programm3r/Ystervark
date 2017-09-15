using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class QuoteLineItemMisc
    {
        public QuoteLineItemMisc()
        {
            InvoiceLineItem = new HashSet<InvoiceLineItem>();
        }

        public int QuoteLineItemMiscId { get; set; }
        public int QuoteLineId { get; set; }
        public string Description { get; set; }
        public int Qty { get; set; }
        public decimal Amount { get; set; }
        public decimal UnitPrice { get; set; }

        public QuoteLine QuoteLine { get; set; }
        public ICollection<InvoiceLineItem> InvoiceLineItem { get; set; }
    }
}
