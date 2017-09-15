using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class InvoiceLineItemTime
    {
        public int Id { get; set; }
        public int InvoiceLineItemId { get; set; }
        public int TimeId { get; set; }
        public decimal Rate { get; set; }
        public decimal Hours { get; set; }

        public InvoiceLineItem InvoiceLineItem { get; set; }
        public Time Time { get; set; }
    }
}
