using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Resource
    {
        public Resource()
        {
            ApprovalConfigCreatedByNavigation = new HashSet<ApprovalConfig>();
            ApprovalConfigUpdatedByNavigation = new HashSet<ApprovalConfig>();
            ApprovalRecipient = new HashSet<ApprovalRecipient>();
            BookingBooker = new HashSet<Booking>();
            BookingResource = new HashSet<Booking>();
            ClientClientManager = new HashSet<Client>();
            ClientCreatedByNavigation = new HashSet<Client>();
            ClientUpdatedByNavigation = new HashSet<Client>();
            Comment = new HashSet<Comment>();
            Competency = new HashSet<Competency>();
            Connection = new HashSet<Connection>();
            Coupon = new HashSet<Coupon>();
            CreditNoteCreatedByResource = new HashSet<CreditNote>();
            CreditNoteUpdatedByResource = new HashSet<CreditNote>();
            DeviceProfile = new HashSet<DeviceProfile>();
            Expense = new HashSet<Expense>();
            InvoiceCreatedByResource = new HashSet<Invoice>();
            InvoicePaymentCreatedBy = new HashSet<InvoicePayment>();
            InvoicePaymentUpdatedBy = new HashSet<InvoicePayment>();
            InvoiceUpdatedByResource = new HashSet<Invoice>();
            Journey = new HashSet<Journey>();
            Licence = new HashSet<Licence>();
            MessageGroupMembers = new HashSet<MessageGroupMembers>();
            MessagesFromNavigation = new HashSet<Messages>();
            MessagesToNavigation = new HashSet<Messages>();
            NonBillableTimeCreatedByResource = new HashSet<NonBillableTime>();
            NonBillableTimeUpdatedByResource = new HashSet<NonBillableTime>();
            OpportunityCapturedBy = new HashSet<Opportunity>();
            OpportunityReferredByResource = new HashSet<Opportunity>();
            OpportunityUpdatedByNavigation = new HashSet<Opportunity>();
            ProjectCreatedByNavigation = new HashSet<Project>();
            ProjectMilestoneTask = new HashSet<ProjectMilestoneTask>();
            ProjectProjectManger = new HashSet<Project>();
            ProjectRate = new HashSet<ProjectRate>();
            ProjectResourceLink = new HashSet<ProjectResourceLink>();
            ProjectUpdatedByNavigation = new HashSet<Project>();
            QuoteApprovalUser = new HashSet<Quote>();
            QuoteChangedByNavigation = new HashSet<Quote>();
            QuoteCreatedByNavigation = new HashSet<Quote>();
            QuoteUser = new HashSet<Quote>();
            ResourceLocation = new HashSet<ResourceLocation>();
            ResourceRateCreatedByResource = new HashSet<ResourceRate>();
            ResourceRateResource = new HashSet<ResourceRate>();
            ResourceRateUpdatedByResource = new HashSet<ResourceRate>();
            ResourceRole = new HashSet<ResourceRole>();
            ResourceSkill = new HashSet<ResourceSkill>();
            ResourceTeam = new HashSet<ResourceTeam>();
            TaskAssignedToNavigation = new HashSet<Task>();
            TaskCommentUser = new HashSet<Task>();
            TaskRequestedByNavigation = new HashSet<Task>();
            Team = new HashSet<Team>();
            TemplateLine = new HashSet<TemplateLine>();
            TemplateLineItem = new HashSet<TemplateLineItem>();
            Time = new HashSet<Time>();
        }

        public int ResourceId { get; set; }
        public string ResourceName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Emailaddress { get; set; }
        public DateTime? DateInserted { get; set; }
        public string CellPhoneNr { get; set; }
        public int TenantId { get; set; }
        public bool? IsTopLevelAdmin { get; set; }
        public int? RegionId { get; set; }
        public int? ClientId { get; set; }
        public int? ResourceTypeId { get; set; }
        public int? PhysicalAddressId { get; set; }
        public string ImageUrl { get; set; }
        public int? BankDetailId { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public ResourceBankDetail BankDetail { get; set; }
        public Client Client { get; set; }
        public Address PhysicalAddress { get; set; }
        public Region Region { get; set; }
        public ResourceType ResourceType { get; set; }
        public Tenant Tenant { get; set; }
        public ResourceImage ResourceImage { get; set; }
        public ICollection<ApprovalConfig> ApprovalConfigCreatedByNavigation { get; set; }
        public ICollection<ApprovalConfig> ApprovalConfigUpdatedByNavigation { get; set; }
        public ICollection<ApprovalRecipient> ApprovalRecipient { get; set; }
        public ICollection<Booking> BookingBooker { get; set; }
        public ICollection<Booking> BookingResource { get; set; }
        public ICollection<Client> ClientClientManager { get; set; }
        public ICollection<Client> ClientCreatedByNavigation { get; set; }
        public ICollection<Client> ClientUpdatedByNavigation { get; set; }
        public ICollection<Comment> Comment { get; set; }
        public ICollection<Competency> Competency { get; set; }
        public ICollection<Connection> Connection { get; set; }
        public ICollection<Coupon> Coupon { get; set; }
        public ICollection<CreditNote> CreditNoteCreatedByResource { get; set; }
        public ICollection<CreditNote> CreditNoteUpdatedByResource { get; set; }
        public ICollection<DeviceProfile> DeviceProfile { get; set; }
        public ICollection<Expense> Expense { get; set; }
        public ICollection<Invoice> InvoiceCreatedByResource { get; set; }
        public ICollection<InvoicePayment> InvoicePaymentCreatedBy { get; set; }
        public ICollection<InvoicePayment> InvoicePaymentUpdatedBy { get; set; }
        public ICollection<Invoice> InvoiceUpdatedByResource { get; set; }
        public ICollection<Journey> Journey { get; set; }
        public ICollection<Licence> Licence { get; set; }
        public ICollection<MessageGroupMembers> MessageGroupMembers { get; set; }
        public ICollection<Messages> MessagesFromNavigation { get; set; }
        public ICollection<Messages> MessagesToNavigation { get; set; }
        public ICollection<NonBillableTime> NonBillableTimeCreatedByResource { get; set; }
        public ICollection<NonBillableTime> NonBillableTimeUpdatedByResource { get; set; }
        public ICollection<Opportunity> OpportunityCapturedBy { get; set; }
        public ICollection<Opportunity> OpportunityReferredByResource { get; set; }
        public ICollection<Opportunity> OpportunityUpdatedByNavigation { get; set; }
        public ICollection<Project> ProjectCreatedByNavigation { get; set; }
        public ICollection<ProjectMilestoneTask> ProjectMilestoneTask { get; set; }
        public ICollection<Project> ProjectProjectManger { get; set; }
        public ICollection<ProjectRate> ProjectRate { get; set; }
        public ICollection<ProjectResourceLink> ProjectResourceLink { get; set; }
        public ICollection<Project> ProjectUpdatedByNavigation { get; set; }
        public ICollection<Quote> QuoteApprovalUser { get; set; }
        public ICollection<Quote> QuoteChangedByNavigation { get; set; }
        public ICollection<Quote> QuoteCreatedByNavigation { get; set; }
        public ICollection<Quote> QuoteUser { get; set; }
        public ICollection<ResourceLocation> ResourceLocation { get; set; }
        public ICollection<ResourceRate> ResourceRateCreatedByResource { get; set; }
        public ICollection<ResourceRate> ResourceRateResource { get; set; }
        public ICollection<ResourceRate> ResourceRateUpdatedByResource { get; set; }
        public ICollection<ResourceRole> ResourceRole { get; set; }
        public ICollection<ResourceSkill> ResourceSkill { get; set; }
        public ICollection<ResourceTeam> ResourceTeam { get; set; }
        public ICollection<Task> TaskAssignedToNavigation { get; set; }
        public ICollection<Task> TaskCommentUser { get; set; }
        public ICollection<Task> TaskRequestedByNavigation { get; set; }
        public ICollection<Team> Team { get; set; }
        public ICollection<TemplateLine> TemplateLine { get; set; }
        public ICollection<TemplateLineItem> TemplateLineItem { get; set; }
        public ICollection<Time> Time { get; set; }
    }
}
