using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Quote
    {
        public Quote()
        {
            AttachmentLink = new HashSet<AttachmentLink>();
            InvoiceProject = new HashSet<InvoiceProject>();
            QuoteLine = new HashSet<QuoteLine>();
        }

        public int QuoteId { get; set; }
        public int TenantId { get; set; }
        public string ReferenceNumber { get; set; }
        public int UserId { get; set; }
        public int ClientId { get; set; }
        public string QuoteName { get; set; }
        public string QuoteDescription { get; set; }
        public string DiscountText { get; set; }
        public decimal? DiscountAmount { get; set; }
        public DateTime? ApprovalDateTime { get; set; }
        public int? ApprovalUserId { get; set; }
        public int CompetencyId { get; set; }
        public int? ProjectTypeId { get; set; }
        public int? ProjectId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string ScopeOfWorkDescription { get; set; }
        public bool? Archived { get; set; }
        public int? OpportunityId { get; set; }
        public int CurrencyId { get; set; }
        public string AltReference { get; set; }
        public int? ChangedBy { get; set; }
        public DateTime ChangedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? Vat { get; set; }
        public decimal? Total { get; set; }
        public bool? IsApproved { get; set; }

        public Resource ApprovalUser { get; set; }
        public Resource ChangedByNavigation { get; set; }
        public Client Client { get; set; }
        public Competency Competency { get; set; }
        public Resource CreatedByNavigation { get; set; }
        public Currency Currency { get; set; }
        public Opportunity Opportunity { get; set; }
        public Project Project { get; set; }
        public ProjectType ProjectType { get; set; }
        public Tenant Tenant { get; set; }
        public Resource User { get; set; }
        public ICollection<AttachmentLink> AttachmentLink { get; set; }
        public ICollection<InvoiceProject> InvoiceProject { get; set; }
        public ICollection<QuoteLine> QuoteLine { get; set; }
    }
}
