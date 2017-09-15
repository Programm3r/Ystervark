using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class InvoicePaymentDetails
    {
        public int Id { get; set; }
        public int InvoicePaymentId { get; set; }
        public int InvoiceId { get; set; }
        public decimal Amount { get; set; }

        public Invoice Invoice { get; set; }
        public InvoicePayment InvoicePayment { get; set; }
    }
}
