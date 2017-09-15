using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class InvoicePayment
    {
        public InvoicePayment()
        {
            InvoicePaymentDetails = new HashSet<InvoicePaymentDetails>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public int PaymentTypeId { get; set; }
        public string Description { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedById { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedById { get; set; }
        public decimal? Total { get; set; }
        public string PaymentNumber { get; set; }
        public int CurrencyId { get; set; }

        public Client Client { get; set; }
        public Resource CreatedBy { get; set; }
        public Currency Currency { get; set; }
        public PaymentType PaymentType { get; set; }
        public Resource UpdatedBy { get; set; }
        public ICollection<InvoicePaymentDetails> InvoicePaymentDetails { get; set; }
    }
}
