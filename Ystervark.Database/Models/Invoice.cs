using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Invoice
    {
        public Invoice()
        {
            CreditNote = new HashSet<CreditNote>();
            InvoicePaymentDetails = new HashSet<InvoicePaymentDetails>();
            InvoiceProject = new HashSet<InvoiceProject>();
        }

        public int Id { get; set; }
        public int TenantId { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public decimal Vat { get; set; }
        public int? ClientId { get; set; }
        public decimal Discount { get; set; }
        public bool? Archived { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? CreatedByResourceId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedByResourceId { get; set; }
        public int CurrencyId { get; set; }
        public string AltReference { get; set; }

        public Client Client { get; set; }
        public Resource CreatedByResource { get; set; }
        public Currency Currency { get; set; }
        public Tenant Tenant { get; set; }
        public Resource UpdatedByResource { get; set; }
        public ICollection<CreditNote> CreditNote { get; set; }
        public ICollection<InvoicePaymentDetails> InvoicePaymentDetails { get; set; }
        public ICollection<InvoiceProject> InvoiceProject { get; set; }
    }
}
