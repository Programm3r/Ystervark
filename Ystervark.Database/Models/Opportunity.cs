using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Opportunity
    {
        public Opportunity()
        {
            AttachmentLink = new HashSet<AttachmentLink>();
            OpportunityComment = new HashSet<OpportunityComment>();
            OpportunityContact = new HashSet<OpportunityContact>();
            Quote = new HashSet<Quote>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? EstimatedValue { get; set; }
        public decimal? EstimatedRevenue { get; set; }
        public int? ClientId { get; set; }
        public int? ReferredByResourceId { get; set; }
        public int? SourceId { get; set; }
        public int? RatingId { get; set; }
        public int? TimeFrameId { get; set; }
        public int? RegionId { get; set; }
        public int? CompetencyId { get; set; }
        public int? CurrencyId { get; set; }
        public int? OutcomeId { get; set; }
        public int TenantId { get; set; }
        public int CrmStateId { get; set; }
        public int CapturedById { get; set; }
        public DateTime CapturedOn { get; set; }
        public DateTime? EstimatedClosingDate { get; set; }
        public int? CategoryId { get; set; }
        public bool? Archived { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public string ReferenceNumber { get; set; }

        public Resource CapturedBy { get; set; }
        public OpportunityCategory Category { get; set; }
        public Client Client { get; set; }
        public Competency Competency { get; set; }
        public CrmState CrmState { get; set; }
        public Currency Currency { get; set; }
        public OpportunityOutcome Outcome { get; set; }
        public OpportunityRating Rating { get; set; }
        public Resource ReferredByResource { get; set; }
        public Region Region { get; set; }
        public OpportunitySource Source { get; set; }
        public Tenant Tenant { get; set; }
        public TimeFrame TimeFrame { get; set; }
        public Resource UpdatedByNavigation { get; set; }
        public ICollection<AttachmentLink> AttachmentLink { get; set; }
        public ICollection<OpportunityComment> OpportunityComment { get; set; }
        public ICollection<OpportunityContact> OpportunityContact { get; set; }
        public ICollection<Quote> Quote { get; set; }
    }
}
