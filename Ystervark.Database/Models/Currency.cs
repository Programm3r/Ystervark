using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Currency
    {
        public Currency()
        {
            Invoice = new HashSet<Invoice>();
            InvoicePayment = new HashSet<InvoicePayment>();
            Opportunity = new HashSet<Opportunity>();
            Quote = new HashSet<Quote>();
        }

        public int Id { get; set; }
        public string Country { get; set; }
        public string Symbol { get; set; }
        public string Code { get; set; }

        public ICollection<Invoice> Invoice { get; set; }
        public ICollection<InvoicePayment> InvoicePayment { get; set; }
        public ICollection<Opportunity> Opportunity { get; set; }
        public ICollection<Quote> Quote { get; set; }
    }
}
