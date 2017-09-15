using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class PaymentType
    {
        public PaymentType()
        {
            InvoicePayment = new HashSet<InvoicePayment>();
        }

        public int Id { get; set; }
        public string EnumName { get; set; }
        public string Description { get; set; }

        public ICollection<InvoicePayment> InvoicePayment { get; set; }
    }
}
