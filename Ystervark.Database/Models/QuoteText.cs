using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class QuoteText
    {
        public int Id { get; set; }
        public int TenantId { get; set; }
        public string VatregNo { get; set; }
        public string RegNo { get; set; }
        public string PostalLine1 { get; set; }
        public string PostalLine2 { get; set; }
        public string PostalLine3 { get; set; }
        public string PostalLine4 { get; set; }
        public string PostalCode { get; set; }
        public string FaxNo { get; set; }
        public string TenantUrl { get; set; }
        public string GeneralTerms { get; set; }
        public string TenantLogoUrl { get; set; }
        public string AcceptanceTerms { get; set; }

        public Tenant Tenant { get; set; }
    }
}
