using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Tenant
    {
        public Tenant()
        {
            ApprovalConfig = new HashSet<ApprovalConfig>();
            BankDetails = new HashSet<BankDetails>();
            BillingLocker = new HashSet<BillingLocker>();
            Booking = new HashSet<Booking>();
            Client = new HashSet<Client>();
            ClientType = new HashSet<ClientType>();
            Comment = new HashSet<Comment>();
            Competency = new HashSet<Competency>();
            Contact = new HashSet<Contact>();
            Coupon = new HashSet<Coupon>();
            Expense = new HashSet<Expense>();
            ExpenseCategory = new HashSet<ExpenseCategory>();
            Invoice = new HashSet<Invoice>();
            InvoiceText = new HashSet<InvoiceText>();
            Licence = new HashSet<Licence>();
            NonWorkingDay = new HashSet<NonWorkingDay>();
            Opportunity = new HashSet<Opportunity>();
            OpportunitySource = new HashSet<OpportunitySource>();
            Partner = new HashSet<Partner>();
            Project = new HashSet<Project>();
            ProjectRate = new HashSet<ProjectRate>();
            ProjectType = new HashSet<ProjectType>();
            Quote = new HashSet<Quote>();
            QuoteRate = new HashSet<QuoteRate>();
            QuoteText = new HashSet<QuoteText>();
            Region = new HashSet<Region>();
            Resource = new HashSet<Resource>();
            ResourceLocation = new HashSet<ResourceLocation>();
            ResourceRate = new HashSet<ResourceRate>();
            ResourceType = new HashSet<ResourceType>();
            Skill = new HashSet<Skill>();
            Task = new HashSet<Task>();
            TaskHeader = new HashSet<TaskHeader>();
            Team = new HashSet<Team>();
            TemplateLine = new HashSet<TemplateLine>();
            TenantConfig = new HashSet<TenantConfig>();
            TenantRule = new HashSet<TenantRule>();
            Time = new HashSet<Time>();
            TimeFrame = new HashSet<TimeFrame>();
        }

        public int TenantId { get; set; }
        public string TenantName { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressCity { get; set; }
        public string AddressCountry { get; set; }
        public string AddressPostCode { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? SubscriptionEndDate { get; set; }
        public DateTime? LastPaymentDate { get; set; }
        public int? PricingPlanId { get; set; }
        public string LogoPath { get; set; }
        public string VatregNo { get; set; }
        public string RegNo { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }

        public PricingPlan PricingPlan { get; set; }
        public ICollection<ApprovalConfig> ApprovalConfig { get; set; }
        public ICollection<BankDetails> BankDetails { get; set; }
        public ICollection<BillingLocker> BillingLocker { get; set; }
        public ICollection<Booking> Booking { get; set; }
        public ICollection<Client> Client { get; set; }
        public ICollection<ClientType> ClientType { get; set; }
        public ICollection<Comment> Comment { get; set; }
        public ICollection<Competency> Competency { get; set; }
        public ICollection<Contact> Contact { get; set; }
        public ICollection<Coupon> Coupon { get; set; }
        public ICollection<Expense> Expense { get; set; }
        public ICollection<ExpenseCategory> ExpenseCategory { get; set; }
        public ICollection<Invoice> Invoice { get; set; }
        public ICollection<InvoiceText> InvoiceText { get; set; }
        public ICollection<Licence> Licence { get; set; }
        public ICollection<NonWorkingDay> NonWorkingDay { get; set; }
        public ICollection<Opportunity> Opportunity { get; set; }
        public ICollection<OpportunitySource> OpportunitySource { get; set; }
        public ICollection<Partner> Partner { get; set; }
        public ICollection<Project> Project { get; set; }
        public ICollection<ProjectRate> ProjectRate { get; set; }
        public ICollection<ProjectType> ProjectType { get; set; }
        public ICollection<Quote> Quote { get; set; }
        public ICollection<QuoteRate> QuoteRate { get; set; }
        public ICollection<QuoteText> QuoteText { get; set; }
        public ICollection<Region> Region { get; set; }
        public ICollection<Resource> Resource { get; set; }
        public ICollection<ResourceLocation> ResourceLocation { get; set; }
        public ICollection<ResourceRate> ResourceRate { get; set; }
        public ICollection<ResourceType> ResourceType { get; set; }
        public ICollection<Skill> Skill { get; set; }
        public ICollection<Task> Task { get; set; }
        public ICollection<TaskHeader> TaskHeader { get; set; }
        public ICollection<Team> Team { get; set; }
        public ICollection<TemplateLine> TemplateLine { get; set; }
        public ICollection<TenantConfig> TenantConfig { get; set; }
        public ICollection<TenantRule> TenantRule { get; set; }
        public ICollection<Time> Time { get; set; }
        public ICollection<TimeFrame> TimeFrame { get; set; }
    }
}
