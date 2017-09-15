using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Ystervark.Database.Models
{
    public partial class Briteplan : DbContext
    {
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<ApprovalConfig> ApprovalConfig { get; set; }
        public virtual DbSet<ApprovalRecipient> ApprovalRecipient { get; set; }
        public virtual DbSet<ApprovalStatus> ApprovalStatus { get; set; }
        public virtual DbSet<Attachment> Attachment { get; set; }
        public virtual DbSet<AttachmentLink> AttachmentLink { get; set; }
        public virtual DbSet<Audit> Audit { get; set; }
        public virtual DbSet<BankDetails> BankDetails { get; set; }
        public virtual DbSet<BatchNumber> BatchNumber { get; set; }
        public virtual DbSet<BillingLocker> BillingLocker { get; set; }
        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<ClientContact> ClientContact { get; set; }
        public virtual DbSet<ClientSite> ClientSite { get; set; }
        public virtual DbSet<ClientType> ClientType { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Competency> Competency { get; set; }
        public virtual DbSet<CompetencySkill> CompetencySkill { get; set; }
        public virtual DbSet<ConfigKey> ConfigKey { get; set; }
        public virtual DbSet<ConfigSetup> ConfigSetup { get; set; }
        public virtual DbSet<Connection> Connection { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<ContactType> ContactType { get; set; }
        public virtual DbSet<ContactTypeMap> ContactTypeMap { get; set; }
        public virtual DbSet<ContentType> ContentType { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Coupon> Coupon { get; set; }
        public virtual DbSet<CreditNote> CreditNote { get; set; }
        public virtual DbSet<CreditNoteLine> CreditNoteLine { get; set; }
        public virtual DbSet<CreditNoteLineItem> CreditNoteLineItem { get; set; }
        public virtual DbSet<CreditNoteProject> CreditNoteProject { get; set; }
        public virtual DbSet<CrmState> CrmState { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<DeviceProfile> DeviceProfile { get; set; }
        public virtual DbSet<ErrorReport> ErrorReport { get; set; }
        public virtual DbSet<Expense> Expense { get; set; }
        public virtual DbSet<ExpenseCategory> ExpenseCategory { get; set; }
        public virtual DbSet<ExpenseCategoryType> ExpenseCategoryType { get; set; }
        public virtual DbSet<ExpenseException> ExpenseException { get; set; }
        public virtual DbSet<ExpenseTransaction> ExpenseTransaction { get; set; }
        public virtual DbSet<FileType> FileType { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<InvoiceLine> InvoiceLine { get; set; }
        public virtual DbSet<InvoiceLineItem> InvoiceLineItem { get; set; }
        public virtual DbSet<InvoiceLineItemTime> InvoiceLineItemTime { get; set; }
        public virtual DbSet<InvoicePayment> InvoicePayment { get; set; }
        public virtual DbSet<InvoicePaymentDetails> InvoicePaymentDetails { get; set; }
        public virtual DbSet<InvoiceProject> InvoiceProject { get; set; }
        public virtual DbSet<InvoiceText> InvoiceText { get; set; }
        public virtual DbSet<Journey> Journey { get; set; }
        public virtual DbSet<JourneyRoute> JourneyRoute { get; set; }
        public virtual DbSet<Licence> Licence { get; set; }
        public virtual DbSet<LicenseType> LicenseType { get; set; }
        public virtual DbSet<MessageGroup> MessageGroup { get; set; }
        public virtual DbSet<MessageGroupMembers> MessageGroupMembers { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<NonBillableTime> NonBillableTime { get; set; }
        public virtual DbSet<NonWorkingDay> NonWorkingDay { get; set; }
        public virtual DbSet<Opportunity> Opportunity { get; set; }
        public virtual DbSet<OpportunityCategory> OpportunityCategory { get; set; }
        public virtual DbSet<OpportunityComment> OpportunityComment { get; set; }
        public virtual DbSet<OpportunityContact> OpportunityContact { get; set; }
        public virtual DbSet<OpportunityOutcome> OpportunityOutcome { get; set; }
        public virtual DbSet<OpportunityRating> OpportunityRating { get; set; }
        public virtual DbSet<OpportunitySource> OpportunitySource { get; set; }
        public virtual DbSet<Partner> Partner { get; set; }
        public virtual DbSet<PartnerEngagementType> PartnerEngagementType { get; set; }
        public virtual DbSet<PartnerMargin> PartnerMargin { get; set; }
        public virtual DbSet<PaymentType> PaymentType { get; set; }
        public virtual DbSet<PricingPlan> PricingPlan { get; set; }
        public virtual DbSet<Priority> Priority { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductLicense> ProductLicense { get; set; }
        public virtual DbSet<ProductRule> ProductRule { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<ProjectAttachmentType> ProjectAttachmentType { get; set; }
        public virtual DbSet<ProjectCategory> ProjectCategory { get; set; }
        public virtual DbSet<ProjectComment> ProjectComment { get; set; }
        public virtual DbSet<ProjectMilestone> ProjectMilestone { get; set; }
        public virtual DbSet<ProjectMilestoneTask> ProjectMilestoneTask { get; set; }
        public virtual DbSet<ProjectRate> ProjectRate { get; set; }
        public virtual DbSet<ProjectResourceLink> ProjectResourceLink { get; set; }
        public virtual DbSet<ProjectType> ProjectType { get; set; }
        public virtual DbSet<Quote> Quote { get; set; }
        public virtual DbSet<QuoteLine> QuoteLine { get; set; }
        public virtual DbSet<QuoteLineItem> QuoteLineItem { get; set; }
        public virtual DbSet<QuoteLineItemMisc> QuoteLineItemMisc { get; set; }
        public virtual DbSet<QuoteRate> QuoteRate { get; set; }
        public virtual DbSet<QuoteText> QuoteText { get; set; }
        public virtual DbSet<Race> Race { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Resource> Resource { get; set; }
        public virtual DbSet<ResourceBankDetail> ResourceBankDetail { get; set; }
        public virtual DbSet<ResourceImage> ResourceImage { get; set; }
        public virtual DbSet<ResourceLocation> ResourceLocation { get; set; }
        public virtual DbSet<ResourceRate> ResourceRate { get; set; }
        public virtual DbSet<ResourceRole> ResourceRole { get; set; }
        public virtual DbSet<ResourceSkill> ResourceSkill { get; set; }
        public virtual DbSet<ResourceSkillHistory> ResourceSkillHistory { get; set; }
        public virtual DbSet<ResourceTeam> ResourceTeam { get; set; }
        public virtual DbSet<ResourceType> ResourceType { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<SentEmailHistory> SentEmailHistory { get; set; }
        public virtual DbSet<Skill> Skill { get; set; }
        public virtual DbSet<StorageProvider> StorageProvider { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<TagBooking> TagBooking { get; set; }
        public virtual DbSet<TagProject> TagProject { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<TaskHeader> TaskHeader { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<TemplateHeader> TemplateHeader { get; set; }
        public virtual DbSet<TemplateHeaderType> TemplateHeaderType { get; set; }
        public virtual DbSet<TemplateLine> TemplateLine { get; set; }
        public virtual DbSet<TemplateLineItem> TemplateLineItem { get; set; }
        public virtual DbSet<TemplateType> TemplateType { get; set; }
        public virtual DbSet<Tenant> Tenant { get; set; }
        public virtual DbSet<TenantConfig> TenantConfig { get; set; }
        public virtual DbSet<TenantRule> TenantRule { get; set; }
        public virtual DbSet<Time> Time { get; set; }
        public virtual DbSet<TimeApprovalStatus> TimeApprovalStatus { get; set; }
        public virtual DbSet<TimeFrame> TimeFrame { get; set; }
        public virtual DbSet<TimesheetTimer> TimesheetTimer { get; set; }
        public virtual DbSet<Verification> Verification { get; set; }
        public virtual DbSet<WizardStep> WizardStep { get; set; }
        public virtual DbSet<WizardTemplate> WizardTemplate { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=.\;Database=BriteplanPROD;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Line1)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Suburb)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_Country");
            });

            modelBuilder.Entity<ApprovalConfig>(entity =>
            {
                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntityType)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.ApprovalStatus)
                    .WithMany(p => p.ApprovalConfig)
                    .HasForeignKey(d => d.ApprovalStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApprovalConfig_ApprovalStatus");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ApprovalConfigCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApprovalConfig_CreatedByResource");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.ApprovalConfig)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApprovalConfig_Tenant");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.ApprovalConfigUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_ApprovalConfig_UpdatedByResource");
            });

            modelBuilder.Entity<ApprovalRecipient>(entity =>
            {
                entity.HasOne(d => d.ApprovalConfig)
                    .WithMany(p => p.ApprovalRecipient)
                    .HasForeignKey(d => d.ApprovalConfigId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApprovalRecipient_ApprovalConfig");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.ApprovalRecipient)
                    .HasForeignKey(d => d.ResourceId)
                    .HasConstraintName("FK_ApprovalRecipient_Resource");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.ApprovalRecipient)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_ApprovalRecipient_Role");
            });

            modelBuilder.Entity<ApprovalStatus>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Attachment>(entity =>
            {
                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nchar(500)");

                entity.Property(e => e.Type)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<AttachmentLink>(entity =>
            {
                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Attachment)
                    .WithMany(p => p.AttachmentLink)
                    .HasForeignKey(d => d.AttachmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AttachmentLink_Attachment");

                entity.HasOne(d => d.Expense)
                    .WithMany(p => p.AttachmentLink)
                    .HasForeignKey(d => d.ExpenseId)
                    .HasConstraintName("FK_AttachmentLink_Expense");

                entity.HasOne(d => d.Opportunity)
                    .WithMany(p => p.AttachmentLink)
                    .HasForeignKey(d => d.OpportunityId)
                    .HasConstraintName("FK_AttachmentLink_Opportunity");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.AttachmentLink)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_AttachmentLink_Project");

                entity.HasOne(d => d.Quote)
                    .WithMany(p => p.AttachmentLink)
                    .HasForeignKey(d => d.QuoteId)
                    .HasConstraintName("FK_AttachmentLink_Quote");
            });

            modelBuilder.Entity<Audit>(entity =>
            {
                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasColumnType("char(1)");

                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DateStamp).HasColumnType("datetime");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BankDetails>(entity =>
            {
                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.BankDetails)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BankDetails_Tenant");
            });

            modelBuilder.Entity<BatchNumber>(entity =>
            {
                entity.HasKey(e => new { e.Batch, e.UniqueKey, e.TenantId });

                entity.Property(e => e.Batch)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueKey)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BillingLocker>(entity =>
            {
                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.ToDate).HasColumnType("date");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.BillingLocker)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillingLocker_Client");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.BillingLocker)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillingLocker_Tenant");
            });

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BookerId).HasColumnName("BookerID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.NonWorkingIncluded).HasDefaultValueSql("((1))");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ProjectMilestoneId).HasColumnName("ProjectMilestoneID");

                entity.Property(e => e.ProjectMilestoneTaskId).HasColumnName("ProjectMilestoneTaskID");

                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");

                entity.Property(e => e.TeamLeadId).HasColumnName("TeamLeadID");

                entity.Property(e => e.TenantId).HasDefaultValueSql("((1))");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.HasOne(d => d.Booker)
                    .WithMany(p => p.BookingBooker)
                    .HasForeignKey(d => d.BookerId)
                    .HasConstraintName("FK_Booking_ResourceBooker");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Booking)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_Booking_Project");

                entity.HasOne(d => d.ProjectMilestone)
                    .WithMany(p => p.Booking)
                    .HasForeignKey(d => d.ProjectMilestoneId)
                    .HasConstraintName("FK_Booking_ProjectMilestone");

                entity.HasOne(d => d.ProjectMilestoneTask)
                    .WithMany(p => p.Booking)
                    .HasForeignKey(d => d.ProjectMilestoneTaskId)
                    .HasConstraintName("FK_Booking_ProjectMilestoneTask");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.BookingResource)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Booking_Resource");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Booking)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Booking_Tenant");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasIndex(e => new { e.AccountNumber, e.TenantId })
                    .HasName("IX_Client")
                    .IsUnique();

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Archived).HasDefaultValueSql("((0))");

                entity.Property(e => e.BillingPeriodStart).HasDefaultValueSql("((1))");

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyRegNumber)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ContactEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateInserted)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DefaultRatePerHour).HasColumnType("money");

                entity.Property(e => e.ImageUrl).HasMaxLength(1000);

                entity.Property(e => e.PhysicalAdressOld)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAdressOld)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Registered)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Tariff)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TenantId).HasDefaultValueSql("((1))");

                entity.Property(e => e.TradingAsName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Vatnumber)
                    .HasColumnName("VATNumber")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ClientManager)
                    .WithMany(p => p.ClientClientManager)
                    .HasForeignKey(d => d.ClientManagerId)
                    .HasConstraintName("FK_Clients_Resource");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ClientCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_Client_CreatedByResource");

                entity.HasOne(d => d.PhysicalAddress)
                    .WithMany(p => p.ClientPhysicalAddress)
                    .HasForeignKey(d => d.PhysicalAddressId)
                    .HasConstraintName("FK_Client_PhysicalAddress");

                entity.HasOne(d => d.PostalAddress)
                    .WithMany(p => p.ClientPostalAddress)
                    .HasForeignKey(d => d.PostalAddressId)
                    .HasConstraintName("FK_Client_PostalAddress");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Client)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK_Client_Region");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Client)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Client_Tenant");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.ClientUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_Client_UpdatedByResource");
            });

            modelBuilder.Entity<ClientContact>(entity =>
            {
                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientContact)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientContact_Client");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ClientContact)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientContact_Contact");
            });

            modelBuilder.Entity<ClientSite>(entity =>
            {
                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.ClientSite)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientSite_Address");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientSite)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientSite_Client");
            });

            modelBuilder.Entity<ClientType>(entity =>
            {
                entity.Property(e => e.ClientTypeId).HasColumnName("ClientTypeID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenantId).HasColumnName("TenantID");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.ClientType)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientType_Tenant");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.PostedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comment_Resource");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comment_Tenant");
            });

            modelBuilder.Entity<Competency>(entity =>
            {
                entity.Property(e => e.ChangedOn).HasColumnType("datetime");

                entity.Property(e => e.CompetencyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenantId).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.CompetencyLead)
                    .WithMany(p => p.Competency)
                    .HasForeignKey(d => d.CompetencyLeadId)
                    .HasConstraintName("FK_Competency_Resource");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Competency)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Competency_Tenant");
            });

            modelBuilder.Entity<CompetencySkill>(entity =>
            {
                entity.Property(e => e.CompetencySkillId).HasColumnName("CompetencySkillID");

                entity.Property(e => e.CompetencyId).HasColumnName("CompetencyID");

                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.HasOne(d => d.Competency)
                    .WithMany(p => p.CompetencySkill)
                    .HasForeignKey(d => d.CompetencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetencySkill_Competency");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.CompetencySkill)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompetencySkill_Skill");
            });

            modelBuilder.Entity<ConfigKey>(entity =>
            {
                entity.Property(e => e.DataType).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.EnumName)
                    .IsRequired()
                    .HasColumnName("Enum_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConfigSetup>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Value).IsRequired();

                entity.HasOne(d => d.ConfigKey)
                    .WithMany(p => p.ConfigSetup)
                    .HasForeignKey(d => d.ConfigKeyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConfigSetup_ConfigKey");
            });

            modelBuilder.Entity<Connection>(entity =>
            {
                entity.Property(e => e.Connected)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ConnectionId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.Connection)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConnectedResource");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasIndex(e => new { e.Email, e.TenantId })
                    .HasName("idx_EmailAndTenat")
                    .IsUnique()
                    .HasFilter("([Email] IS NOT NULL)");

                entity.Property(e => e.BusinessPhone).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.JobTitle).HasMaxLength(150);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MobilePhone).HasMaxLength(50);

                entity.Property(e => e.PhysicalAddress).HasMaxLength(500);

                entity.Property(e => e.PostalAddress).HasMaxLength(500);

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Contact)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contact_Tenant");
            });

            modelBuilder.Entity<ContactType>(entity =>
            {
                entity.HasIndex(e => e.EnumName)
                    .HasName("IX_ContactType")
                    .IsUnique();

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.EnumName)
                    .IsRequired()
                    .HasColumnName("Enum_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ContactTypeMap>(entity =>
            {
                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ContactTypeMap)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContactMap_Contact");

                entity.HasOne(d => d.ContactType)
                    .WithMany(p => p.ContactTypeMap)
                    .HasForeignKey(d => d.ContactTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContactMap_ContactType");
            });

            modelBuilder.Entity<ContentType>(entity =>
            {
                entity.HasIndex(e => e.EnumName)
                    .HasName("IX_ContentType")
                    .IsUnique();

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.EnumName)
                    .IsRequired()
                    .HasColumnName("Enum_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasIndex(e => e.Iso)
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .IsUnique();

                entity.Property(e => e.AltName)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Iso)
                    .IsRequired()
                    .HasColumnName("ISO")
                    .HasColumnType("char(2)");

                entity.Property(e => e.Iso3)
                    .HasColumnName("ISO3")
                    .HasColumnType("char(3)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Coupon>(entity =>
            {
                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Expiry).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Coupon)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Coupon_Resource");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Coupon)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_Coupon_Tenant");
            });

            modelBuilder.Entity<CreditNote>(entity =>
            {
                entity.Property(e => e.AltReference)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Archived).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreditNoteNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.SubTotal).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasColumnType("money");

                entity.HasOne(d => d.CreatedByResource)
                    .WithMany(p => p.CreditNoteCreatedByResource)
                    .HasForeignKey(d => d.CreatedByResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditNote_CreatedByResource");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.CreditNote)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditNote_Invoice");

                entity.HasOne(d => d.UpdatedByResource)
                    .WithMany(p => p.CreditNoteUpdatedByResource)
                    .HasForeignKey(d => d.UpdatedByResourceId)
                    .HasConstraintName("FK_CreditNote_UpdatedResource");
            });

            modelBuilder.Entity<CreditNoteLine>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreditNoteProject)
                    .WithMany(p => p.CreditNoteLine)
                    .HasForeignKey(d => d.CreditNoteProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditNoteLine_CreditNoteProject");

                entity.HasOne(d => d.InvoiceLine)
                    .WithMany(p => p.CreditNoteLine)
                    .HasForeignKey(d => d.InvoiceLineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditNoteLine_InvoiceLine");
            });

            modelBuilder.Entity<CreditNoteLineItem>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NoVatApplicable).HasDefaultValueSql("((0))");

                entity.Property(e => e.Qty).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.CreditNoteLine)
                    .WithMany(p => p.CreditNoteLineItem)
                    .HasForeignKey(d => d.CreditNoteLineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditNoteLineItem_CreditNoteLine");

                entity.HasOne(d => d.InvoiceLineItem)
                    .WithMany(p => p.CreditNoteLineItem)
                    .HasForeignKey(d => d.InvoiceLineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditNoteLineItem_InvoiceLineItem");
            });

            modelBuilder.Entity<CreditNoteProject>(entity =>
            {
                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreditNote)
                    .WithMany(p => p.CreditNoteProject)
                    .HasForeignKey(d => d.CreditNoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditNoteProject_CreditNote");

                entity.HasOne(d => d.InvoiceProject)
                    .WithMany(p => p.CreditNoteProject)
                    .HasForeignKey(d => d.InvoiceProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditNoteProject_InvoiceProject");
            });

            modelBuilder.Entity<CrmState>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.EnumName)
                    .IsRequired()
                    .HasColumnName("Enum_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'ABC')");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<DeviceProfile>(entity =>
            {
                entity.Property(e => e.DeviceId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Platform)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.DeviceProfile)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeviceProfile_Resource");
            });

            modelBuilder.Entity<ErrorReport>(entity =>
            {
                entity.Property(e => e.Message).IsRequired();

                entity.Property(e => e.PayLoad).IsRequired();

                entity.Property(e => e.StackTrace).IsRequired();

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Expense>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Comments)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExpenseDate).HasColumnType("datetime");

                entity.Property(e => e.IsApproved).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsBillable).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProcessAmount).HasColumnType("money");

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.ExpenseCategory)
                    .WithMany(p => p.Expense)
                    .HasForeignKey(d => d.ExpenseCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Expense_ExpenseCategory");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Expense)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Expense_Project");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.Expense)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Expense_Resource");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Expense)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Expense_Tenant");

                entity.HasOne(d => d.Transaction)
                    .WithMany(p => p.Expense)
                    .HasForeignKey(d => d.TransactionId)
                    .HasConstraintName("FK_Expense_ExpenseTransaction");
            });

            modelBuilder.Entity<ExpenseCategory>(entity =>
            {
                entity.Property(e => e.Archived).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Glcode)
                    .HasColumnName("GLCode")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.ExpenseCategoryType)
                    .WithMany(p => p.ExpenseCategory)
                    .HasForeignKey(d => d.ExpenseCategoryTypeId)
                    .HasConstraintName("FK_ExpenseCategory_ExpenseCategoryType");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.ExpenseCategory)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExpenseCategory_Tenant");
            });

            modelBuilder.Entity<ExpenseCategoryType>(entity =>
            {
                entity.Property(e => e.UnitOfMeasure)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExpenseException>(entity =>
            {
                entity.Property(e => e.Exception)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Expense)
                    .WithMany(p => p.ExpenseException)
                    .HasForeignKey(d => d.ExpenseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExpenseException_Expense");
            });

            modelBuilder.Entity<ExpenseTransaction>(entity =>
            {
                entity.Property(e => e.UnitOfMeasure)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnitValue).HasColumnType("money");
            });

            modelBuilder.Entity<FileType>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.EnumName)
                    .IsRequired()
                    .HasColumnName("Enum_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.Property(e => e.AltReference)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Archived).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Discount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvoiceDate).HasColumnType("date");

                entity.Property(e => e.InvoiceNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubTotal).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasColumnType("money");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_Invoice_ClientId");

                entity.HasOne(d => d.CreatedByResource)
                    .WithMany(p => p.InvoiceCreatedByResource)
                    .HasForeignKey(d => d.CreatedByResourceId)
                    .HasConstraintName("FK_Invoice_Resource");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoice_Currency");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoice_Tenant");

                entity.HasOne(d => d.UpdatedByResource)
                    .WithMany(p => p.InvoiceUpdatedByResource)
                    .HasForeignKey(d => d.UpdatedByResourceId)
                    .HasConstraintName("FK_Invoice_UpdatedByResource");
            });

            modelBuilder.Entity<InvoiceLine>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.InvoiceProject)
                    .WithMany(p => p.InvoiceLine)
                    .HasForeignKey(d => d.InvoiceProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceLine_InvoiceProject");

                entity.HasOne(d => d.ProjectMileStone)
                    .WithMany(p => p.InvoiceLine)
                    .HasForeignKey(d => d.ProjectMileStoneId)
                    .HasConstraintName("FK_InvoiceLine_ProjectMilestone");
            });

            modelBuilder.Entity<InvoiceLineItem>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NoVatApplicable).HasDefaultValueSql("((0))");

                entity.Property(e => e.Qty).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.InvoiceLine)
                    .WithMany(p => p.InvoiceLineItem)
                    .HasForeignKey(d => d.InvoiceLineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceLineItem_InvoiceLine");

                entity.HasOne(d => d.ProjectMilestoneTask)
                    .WithMany(p => p.InvoiceLineItem)
                    .HasForeignKey(d => d.ProjectMilestoneTaskId)
                    .HasConstraintName("FK_InvoiceLineItem_ProjectMilestoneTask");

                entity.HasOne(d => d.QuoteLineItemMisc)
                    .WithMany(p => p.InvoiceLineItem)
                    .HasForeignKey(d => d.QuoteLineItemMiscId)
                    .HasConstraintName("FK_InvoiceLineItem_QuoteLineItemMisc");
            });

            modelBuilder.Entity<InvoiceLineItemTime>(entity =>
            {
                entity.HasIndex(e => new { e.TimeId, e.InvoiceLineItemId })
                    .HasName("IndxTimeID");

                entity.HasIndex(e => new { e.Rate, e.Hours, e.TimeId })
                    .HasName("IdxRateHours");

                entity.Property(e => e.Hours).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.HasOne(d => d.InvoiceLineItem)
                    .WithMany(p => p.InvoiceLineItemTime)
                    .HasForeignKey(d => d.InvoiceLineItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceLineItemTime_InvoiceLineItem");

                entity.HasOne(d => d.Time)
                    .WithMany(p => p.InvoiceLineItemTime)
                    .HasForeignKey(d => d.TimeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceLineItemTime_Time");
            });

            modelBuilder.Entity<InvoicePayment>(entity =>
            {
                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDate).HasColumnType("date");

                entity.Property(e => e.PaymentNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.InvoicePayment)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoicePayment_Client");

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.InvoicePaymentCreatedBy)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoicePayment_CreateResource");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.InvoicePayment)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoicePayment_Currency");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.InvoicePayment)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoicePayment_PaymentType");

                entity.HasOne(d => d.UpdatedBy)
                    .WithMany(p => p.InvoicePaymentUpdatedBy)
                    .HasForeignKey(d => d.UpdatedById)
                    .HasConstraintName("FK_InvoicePayment_UpdateResource");
            });

            modelBuilder.Entity<InvoicePaymentDetails>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("money");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoicePaymentDetails)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoicePaymentDetails_Invoice");

                entity.HasOne(d => d.InvoicePayment)
                    .WithMany(p => p.InvoicePaymentDetails)
                    .HasForeignKey(d => d.InvoicePaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoicePaymentDetails_InvoicePayment");
            });

            modelBuilder.Entity<InvoiceProject>(entity =>
            {
                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoiceProject)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceProject_Invoice");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.InvoiceProject)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceProject_Project");

                entity.HasOne(d => d.Quote)
                    .WithMany(p => p.InvoiceProject)
                    .HasForeignKey(d => d.QuoteId)
                    .HasConstraintName("FK_InvoiceProject_Quote");
            });

            modelBuilder.Entity<InvoiceText>(entity =>
            {
                entity.Property(e => e.AcceptanceTerms)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.AccountName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DebtorsEmail)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralTerms)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPerson)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Terms)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.InvoiceText)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceText_Tenant");
            });

            modelBuilder.Entity<Journey>(entity =>
            {
                entity.Property(e => e.TravelDate).HasColumnType("datetime");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.Journey)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Journey_Resource");
            });

            modelBuilder.Entity<JourneyRoute>(entity =>
            {
                entity.Property(e => e.Destination)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.DestinationLabel)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Origin)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.OriginLabel)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.Journey)
                    .WithMany(p => p.JourneyRoute)
                    .HasForeignKey(d => d.JourneyId)
                    .HasConstraintName("FK_JourneyRoute_Journey");
            });

            modelBuilder.Entity<Licence>(entity =>
            {
                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.LicenceType)
                    .WithMany(p => p.Licence)
                    .HasForeignKey(d => d.LicenceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Licence_LicenseType");

                entity.HasOne(d => d.ProductRule)
                    .WithMany(p => p.Licence)
                    .HasForeignKey(d => d.ProductRuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Licence_ProductRule");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.Licence)
                    .HasForeignKey(d => d.ResourceId)
                    .HasConstraintName("FK_Licence_Resource");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Licence)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Licence_Tenant");
            });

            modelBuilder.Entity<LicenseType>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<MessageGroup>(entity =>
            {
                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<MessageGroupMembers>(entity =>
            {
                entity.HasOne(d => d.Group)
                    .WithMany(p => p.MessageGroupMembers)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MessageGroup");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.MessageGroupMembers)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MessageGroupMembers");
            });

            modelBuilder.Entity<Messages>(entity =>
            {
                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.DateRead).HasColumnType("datetime");

                entity.Property(e => e.Header)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.IsGroupMessage).HasDefaultValueSql("((0))");

                entity.Property(e => e.Read).HasDefaultValueSql("((0))");

                entity.Property(e => e.TimeStamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.FromNavigation)
                    .WithMany(p => p.MessagesFromNavigation)
                    .HasForeignKey(d => d.From)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FromResource");

                entity.HasOne(d => d.ToNavigation)
                    .WithMany(p => p.MessagesToNavigation)
                    .HasForeignKey(d => d.To)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ToResource");
            });

            modelBuilder.Entity<NonBillableTime>(entity =>
            {
                entity.HasIndex(e => e.TimeId)
                    .HasName("IX_NonBillableTime")
                    .IsUnique();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.NonBillable).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByResource)
                    .WithMany(p => p.NonBillableTimeCreatedByResource)
                    .HasForeignKey(d => d.CreatedByResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NonBillableTime_CreatedResource");

                entity.HasOne(d => d.Time)
                    .WithOne(p => p.NonBillableTime)
                    .HasForeignKey<NonBillableTime>(d => d.TimeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NonBillableTime_Time");

                entity.HasOne(d => d.UpdatedByResource)
                    .WithMany(p => p.NonBillableTimeUpdatedByResource)
                    .HasForeignKey(d => d.UpdatedByResourceId)
                    .HasConstraintName("FK_NonBillableTime_UpdatedResource");
            });

            modelBuilder.Entity<NonWorkingDay>(entity =>
            {
                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.NonWorkingDay)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PublicHoliday_Tenant");
            });

            modelBuilder.Entity<Opportunity>(entity =>
            {
                entity.Property(e => e.Archived).HasDefaultValueSql("((0))");

                entity.Property(e => e.CapturedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.EstimatedClosingDate).HasColumnType("datetime");

                entity.Property(e => e.EstimatedRevenue).HasColumnType("money");

                entity.Property(e => e.EstimatedValue).HasColumnType("money");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ReferenceNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.CapturedBy)
                    .WithMany(p => p.OpportunityCapturedBy)
                    .HasForeignKey(d => d.CapturedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Opportunity_CapturedBy");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Opportunity)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Opportunity_OpportunityCategory");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Opportunity)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_Opportunity_Client");

                entity.HasOne(d => d.Competency)
                    .WithMany(p => p.Opportunity)
                    .HasForeignKey(d => d.CompetencyId)
                    .HasConstraintName("FK_Opportunity_Competency");

                entity.HasOne(d => d.CrmState)
                    .WithMany(p => p.Opportunity)
                    .HasForeignKey(d => d.CrmStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Opportunity_CrmState");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Opportunity)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_Opportunity_Currency");

                entity.HasOne(d => d.Outcome)
                    .WithMany(p => p.Opportunity)
                    .HasForeignKey(d => d.OutcomeId)
                    .HasConstraintName("FK_Opportunity_OpportunityOutcome");

                entity.HasOne(d => d.Rating)
                    .WithMany(p => p.Opportunity)
                    .HasForeignKey(d => d.RatingId)
                    .HasConstraintName("FK_Opportunity_OpportunityRating");

                entity.HasOne(d => d.ReferredByResource)
                    .WithMany(p => p.OpportunityReferredByResource)
                    .HasForeignKey(d => d.ReferredByResourceId)
                    .HasConstraintName("FK_Opportunity_Resource");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Opportunity)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK_Opportunity_Region");

                entity.HasOne(d => d.Source)
                    .WithMany(p => p.Opportunity)
                    .HasForeignKey(d => d.SourceId)
                    .HasConstraintName("FK_Opportunity_OpportunitySource");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Opportunity)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Opportunity_Tenant");

                entity.HasOne(d => d.TimeFrame)
                    .WithMany(p => p.Opportunity)
                    .HasForeignKey(d => d.TimeFrameId)
                    .HasConstraintName("FK_Opportunity_TimeFrame");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.OpportunityUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_Opportunity_UpdatedBy_Resource");
            });

            modelBuilder.Entity<OpportunityCategory>(entity =>
            {
                entity.HasIndex(e => new { e.EnumName, e.TenantId })
                    .HasName("IX_OpportunityCategory")
                    .IsUnique();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.EnumName)
                    .IsRequired()
                    .HasColumnName("Enum_Name")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<OpportunityComment>(entity =>
            {
                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.OpportunityComment)
                    .HasForeignKey(d => d.CommentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OpportunityComment_Comment");

                entity.HasOne(d => d.Opportunity)
                    .WithMany(p => p.OpportunityComment)
                    .HasForeignKey(d => d.OpportunityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OpportunityComment_Opportunity");
            });

            modelBuilder.Entity<OpportunityContact>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.OpportunityId, e.ContactId });

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.OpportunityContact)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OpportunityContact_Contact");

                entity.HasOne(d => d.Opportunity)
                    .WithMany(p => p.OpportunityContact)
                    .HasForeignKey(d => d.OpportunityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OpportunityContact_Opportunity");
            });

            modelBuilder.Entity<OpportunityOutcome>(entity =>
            {
                entity.HasIndex(e => e.EnumName)
                    .HasName("IX_OpportunityOutcome")
                    .IsUnique();

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.EnumName)
                    .IsRequired()
                    .HasColumnName("Enum_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OpportunityRating>(entity =>
            {
                entity.Property(e => e.Rating)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<OpportunitySource>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.OpportunitySource)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OpportunitySource_Tenant");
            });

            modelBuilder.Entity<Partner>(entity =>
            {
                entity.Property(e => e.PartnerId).HasColumnName("PartnerID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenantId).HasColumnName("TenantID");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Partner)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Partner_Tenant");
            });

            modelBuilder.Entity<PartnerEngagementType>(entity =>
            {
                entity.Property(e => e.PartnerEngagementTypeId).HasColumnName("PartnerEngagementTypeID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenantId).HasColumnName("TenantID");
            });

            modelBuilder.Entity<PartnerMargin>(entity =>
            {
                entity.Property(e => e.PartnerMarginId)
                    .HasColumnName("PartnerMarginID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BaseCostPerHour).HasColumnType("money");

                entity.Property(e => e.DateInserted).HasColumnType("datetime");

                entity.Property(e => e.PartnerEngagementTypeId).HasColumnName("PartnerEngagementTypeID");

                entity.Property(e => e.PartnerId).HasColumnName("PartnerID");

                entity.Property(e => e.ThresholdMax).HasColumnType("money");

                entity.Property(e => e.ThresholdMin).HasColumnType("money");

                entity.HasOne(d => d.PartnerEngagementType)
                    .WithMany(p => p.PartnerMargin)
                    .HasForeignKey(d => d.PartnerEngagementTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartnerMargin_PartnerEngagementType");

                entity.HasOne(d => d.Partner)
                    .WithMany(p => p.PartnerMargin)
                    .HasForeignKey(d => d.PartnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartnerMargin_Partner");

                entity.HasOne(d => d.PartnerMarginNavigation)
                    .WithOne(p => p.InversePartnerMarginNavigation)
                    .HasForeignKey<PartnerMargin>(d => d.PartnerMarginId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PartnerMargin_PartnerMargin");
            });

            modelBuilder.Entity<PaymentType>(entity =>
            {
                entity.HasIndex(e => e.EnumName)
                    .HasName("UK_PaymentType_Enum")
                    .IsUnique();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EnumName)
                    .IsRequired()
                    .HasColumnName("Enum_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PricingPlan>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("IX_PricingModel")
                    .IsUnique();

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.PricingPlan)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PricingModel_Product");
            });

            modelBuilder.Entity<Priority>(entity =>
            {
                entity.HasIndex(e => e.EnumName)
                    .HasName("IX_Priority")
                    .IsUnique();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.EnumName)
                    .IsRequired()
                    .HasColumnName("Enum_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Description).HasColumnType("nchar(50)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nchar(25)");
            });

            modelBuilder.Entity<ProductLicense>(entity =>
            {
                entity.HasOne(d => d.LicenseType)
                    .WithMany(p => p.ProductLicense)
                    .HasForeignKey(d => d.LicenseTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductLicense_LicenseType");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductLicense)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductLicense_Product");
            });

            modelBuilder.Entity<ProductRule>(entity =>
            {
                entity.Property(e => e.Quantity).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductRule)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductRule_Product");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasIndex(e => new { e.ClientId, e.Archived, e.TenantId })
                    .HasName("idxProjectIdTenantId");

                entity.Property(e => e.BudgetedAmount).HasColumnType("money");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CompletionDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NotifyOnTimeLimit).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Ponumber)
                    .HasColumnName("PONumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectTypeId).HasColumnName("ProjectTypeID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TenantId).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project_Client");

                entity.HasOne(d => d.Competency)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.CompetencyId)
                    .HasConstraintName("FK_Project_Competency");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ProjectCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_Project_CreatedByResource");

                entity.HasOne(d => d.ProjectCategory)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.ProjectCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project_ProjectCategory");

                entity.HasOne(d => d.ProjectManger)
                    .WithMany(p => p.ProjectProjectManger)
                    .HasForeignKey(d => d.ProjectMangerId)
                    .HasConstraintName("FK_Project_Resource");

                entity.HasOne(d => d.ProjectType)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.ProjectTypeId)
                    .HasConstraintName("FK_Project_Type");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("FK_Project_Team");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project_Tenant");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.ProjectUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_Project_UpdatedByResource");
            });

            modelBuilder.Entity<ProjectAttachmentType>(entity =>
            {
                entity.HasIndex(e => e.EnumName)
                    .HasName("IX_ProjectAttachmentType")
                    .IsUnique();

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.EnumName)
                    .IsRequired()
                    .HasColumnName("Enum_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ProjectCategory>(entity =>
            {
                entity.HasIndex(e => e.EnumName)
                    .HasName("IX_ProjectCategory")
                    .IsUnique();

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.EnumName)
                    .IsRequired()
                    .HasColumnName("Enum_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ProjectComment>(entity =>
            {
                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.ProjectComment)
                    .HasForeignKey(d => d.CommentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectComment_Comment");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectComment)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectComment_Project");
            });

            modelBuilder.Entity<ProjectMilestone>(entity =>
            {
                entity.Property(e => e.ProjectMileStoneId).HasColumnName("ProjectMileStoneID");

                entity.Property(e => e.CompletionDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.QuoteLineId).HasColumnName("QuoteLineID");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectMilestone)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectMilestone_Project");

                entity.HasOne(d => d.QuoteLine)
                    .WithMany(p => p.ProjectMilestone)
                    .HasForeignKey(d => d.QuoteLineId)
                    .HasConstraintName("FK_ProjectMilestone_QuoteLine");
            });

            modelBuilder.Entity<ProjectMilestoneTask>(entity =>
            {
                entity.Property(e => e.ProjectMilestoneTaskId).HasColumnName("ProjectMilestoneTaskID");

                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.ProjectMilestoneId).HasColumnName("ProjectMilestoneID");

                entity.Property(e => e.QuoteLineItemId).HasColumnName("QuoteLineItemID");

                entity.Property(e => e.QuotedRate).HasColumnType("money");

                entity.Property(e => e.TaskDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ToDate).HasColumnType("date");

                entity.HasOne(d => d.ProjectMilestone)
                    .WithMany(p => p.ProjectMilestoneTask)
                    .HasForeignKey(d => d.ProjectMilestoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectMilestoneTask_ProjectMilestone");

                entity.HasOne(d => d.QuoteLineItem)
                    .WithMany(p => p.ProjectMilestoneTask)
                    .HasForeignKey(d => d.QuoteLineItemId)
                    .HasConstraintName("FK_ProjectMilestoneTask_QuoteLineItem");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.ProjectMilestoneTask)
                    .HasForeignKey(d => d.ResourceId)
                    .HasConstraintName("FK_ProjectMilestoneTask_Resource");
            });

            modelBuilder.Entity<ProjectRate>(entity =>
            {
                entity.HasIndex(e => e.ResourceId)
                    .HasName("ProjectRateResourceIndex");

                entity.HasIndex(e => new { e.ProjectId, e.ResourceId, e.IsActive, e.FromDate, e.ToDate })
                    .HasName("ProjectRateDataIndex");

                entity.Property(e => e.ClientRate).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreatedDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectRate)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectRate_Project");

                entity.HasOne(d => d.ProjectMilestoneTask)
                    .WithMany(p => p.ProjectRate)
                    .HasForeignKey(d => d.ProjectMilestoneTaskId)
                    .HasConstraintName("FK_ProjectRate_ProjectMilestoneTask");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.ProjectRate)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectRate_Resource");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.ProjectRate)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectRate_Tenant");
            });

            modelBuilder.Entity<ProjectResourceLink>(entity =>
            {
                entity.HasIndex(e => new { e.ResourceId, e.ProjectId })
                    .HasName("ProjectResourceLinkUniq")
                    .IsUnique();

                entity.Property(e => e.Archived).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectResourceLink)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectResourceLink_Project");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.ProjectResourceLink)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectResourceLink_Resource");
            });

            modelBuilder.Entity<ProjectType>(entity =>
            {
                entity.Property(e => e.ProjectTypeId).HasColumnName("ProjectTypeID");

                entity.Property(e => e.ProjectTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.ProjectType)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectType_Tenant");
            });

            modelBuilder.Entity<Quote>(entity =>
            {
                entity.Property(e => e.AltReference)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovalDateTime).HasColumnType("datetime");

                entity.Property(e => e.ChangedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DiscountAmount).HasColumnType("money");

                entity.Property(e => e.DiscountText)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsApproved).HasDefaultValueSql("((0))");

                entity.Property(e => e.QuoteDescription)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.QuoteName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ScopeOfWorkDescription)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SubTotal).HasColumnType("money");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasColumnType("money");

                entity.HasOne(d => d.ApprovalUser)
                    .WithMany(p => p.QuoteApprovalUser)
                    .HasForeignKey(d => d.ApprovalUserId)
                    .HasConstraintName("FK_Quote_ApprovalResource");

                entity.HasOne(d => d.ChangedByNavigation)
                    .WithMany(p => p.QuoteChangedByNavigation)
                    .HasForeignKey(d => d.ChangedBy)
                    .HasConstraintName("FK_Quote_ChangedByResource");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Quote)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Quote_Client");

                entity.HasOne(d => d.Competency)
                    .WithMany(p => p.Quote)
                    .HasForeignKey(d => d.CompetencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Quote_Competency");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.QuoteCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_Quote_CreatedByResource");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.Quote)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Quote_Currency");

                entity.HasOne(d => d.Opportunity)
                    .WithMany(p => p.Quote)
                    .HasForeignKey(d => d.OpportunityId)
                    .HasConstraintName("FK_Quote_Opportunity");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Quote)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_Quote_Project");

                entity.HasOne(d => d.ProjectType)
                    .WithMany(p => p.Quote)
                    .HasForeignKey(d => d.ProjectTypeId)
                    .HasConstraintName("FK_Quote_ProjectType");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Quote)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Quote_Tenant");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.QuoteUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Quote_Resource");
            });

            modelBuilder.Entity<QuoteLine>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Quote)
                    .WithMany(p => p.QuoteLine)
                    .HasForeignKey(d => d.QuoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuoteLine_Quote");
            });

            modelBuilder.Entity<QuoteLineItem>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.HasOne(d => d.QuoteLine)
                    .WithMany(p => p.QuoteLineItem)
                    .HasForeignKey(d => d.QuoteLineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuoteLineItem_QuoteLine");

                entity.HasOne(d => d.ResourceType)
                    .WithMany(p => p.QuoteLineItem)
                    .HasForeignKey(d => d.ResourceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuoteLineItem_ResourceType");
            });

            modelBuilder.Entity<QuoteLineItemMisc>(entity =>
            {
                entity.Property(e => e.QuoteLineItemMiscId).HasColumnName("QuoteLineItemMiscID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.QuoteLineId).HasColumnName("QuoteLineID");

                entity.Property(e => e.UnitPrice)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");

                entity.HasOne(d => d.QuoteLine)
                    .WithMany(p => p.QuoteLineItemMisc)
                    .HasForeignKey(d => d.QuoteLineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuoteLineItemMisc_QuoteLine");
            });

            modelBuilder.Entity<QuoteRate>(entity =>
            {
                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProjectTypeId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RatePerHour).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.ProjectType)
                    .WithMany(p => p.QuoteRate)
                    .HasForeignKey(d => d.ProjectTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuoteRate_ProjectType");

                entity.HasOne(d => d.ResourceType)
                    .WithMany(p => p.QuoteRate)
                    .HasForeignKey(d => d.ResourceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuoteRate_ResourceType");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.QuoteRate)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuoteRate_Tenant");
            });

            modelBuilder.Entity<QuoteText>(entity =>
            {
                entity.Property(e => e.AcceptanceTerms)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.FaxNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralTerms)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PostalLine1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PostalLine2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PostalLine3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PostalLine4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenantLogoUrl)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TenantUrl)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.VatregNo)
                    .HasColumnName("VATRegNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.QuoteText)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuoteText_Tenant");
            });

            modelBuilder.Entity<Race>(entity =>
            {
                entity.Property(e => e.RaceId).HasColumnName("RaceID");

                entity.Property(e => e.RaceName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenantId).HasColumnName("TenantID");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.HasIndex(e => new { e.Name, e.TenantId })
                    .HasName("Name")
                    .IsUnique();

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Region)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Region_Tenant");
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.HasIndex(e => e.ResourceName)
                    .HasName("UniqueResourceNameConstraint")
                    .IsUnique();

                entity.Property(e => e.CellPhoneNr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateInserted).HasColumnType("datetime");

                entity.Property(e => e.Emailaddress)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrl).HasMaxLength(1000);

                entity.Property(e => e.IsTopLevelAdmin).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ResourceName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TenantId).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.BankDetail)
                    .WithMany(p => p.Resource)
                    .HasForeignKey(d => d.BankDetailId)
                    .HasConstraintName("FK_Resource_ResourceBankDetail");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Resource)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_Resource_ClientId");

                entity.HasOne(d => d.PhysicalAddress)
                    .WithMany(p => p.Resource)
                    .HasForeignKey(d => d.PhysicalAddressId)
                    .HasConstraintName("FK_Resource_Address");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Resource)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK_Resource_Region");

                entity.HasOne(d => d.ResourceType)
                    .WithMany(p => p.Resource)
                    .HasForeignKey(d => d.ResourceTypeId)
                    .HasConstraintName("FK_Resource_ResourceType");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Resource)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Resource_Tenant");
            });

            modelBuilder.Entity<ResourceBankDetail>(entity =>
            {
                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ResourceImage>(entity =>
            {
                entity.HasKey(e => e.ResourceId);

                entity.Property(e => e.ResourceId).ValueGeneratedNever();

                entity.Property(e => e.Image).IsRequired();

                entity.HasOne(d => d.Resource)
                    .WithOne(p => p.ResourceImage)
                    .HasForeignKey<ResourceImage>(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResourceImage_Resource1");
            });

            modelBuilder.Entity<ResourceLocation>(entity =>
            {
                entity.Property(e => e.Latitude).HasDefaultValueSql("((0))");

                entity.Property(e => e.Longitude).HasDefaultValueSql("((0))");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.ResourceLocation)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResourceLocation_Resource");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.ResourceLocation)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResourceLocation_Tenant");
            });

            modelBuilder.Entity<ResourceRate>(entity =>
            {
                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByResource)
                    .WithMany(p => p.ResourceRateCreatedByResource)
                    .HasForeignKey(d => d.CreatedByResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResourceRate_CreatedByResource");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.ResourceRateResource)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResourceRate_Resource");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.ResourceRate)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResourceRate_Tenant");

                entity.HasOne(d => d.UpdatedByResource)
                    .WithMany(p => p.ResourceRateUpdatedByResource)
                    .HasForeignKey(d => d.UpdatedByResourceId)
                    .HasConstraintName("FK_ResourceRate_UpdatedByResource");
            });

            modelBuilder.Entity<ResourceRole>(entity =>
            {
                entity.HasIndex(e => new { e.ResourceId, e.RoleId })
                    .HasName("UniqueResourceAndRole")
                    .IsUnique();

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.ResourceRole)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResourceRole_Resource");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.ResourceRole)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResourceRole_Role");
            });

            modelBuilder.Entity<ResourceSkill>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");

                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.Property(e => e.SkillLevel).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.ResourceSkill)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResourceSkills_Resource");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.ResourceSkill)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResourceSkills_Skill");
            });

            modelBuilder.Entity<ResourceSkillHistory>(entity =>
            {
                entity.Property(e => e.SkillLevel).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ResourceTeam>(entity =>
            {
                entity.HasIndex(e => new { e.ResourceId, e.TeamId })
                    .HasName("UniqueResourceAndTeam")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TeamId).HasColumnName("TeamID");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.ResourceTeam)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResourceTeam_Resource");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.ResourceTeam)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("FK_ResourceTeam_Team");
            });

            modelBuilder.Entity<ResourceType>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.ResourceType)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ResourceType_Tenant");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RoleDisplayName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SentEmailHistory>(entity =>
            {
                entity.HasKey(e => e.EmailHistoryId);

                entity.Property(e => e.EmailHistoryId).ValueGeneratedNever();

                entity.Property(e => e.Cc)
                    .HasColumnName("CC")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SentTime).HasColumnType("datetime");

                entity.Property(e => e.Subject)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.To)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenantId).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Skill)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Skill_Tenant");
            });

            modelBuilder.Entity<StorageProvider>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.EnumName)
                    .IsRequired()
                    .HasColumnName("Enum_Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TagBooking>(entity =>
            {
                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.TagBooking)
                    .HasForeignKey(d => d.BookingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TagBooking_Booking");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.TagBooking)
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TagBooking_Tag");
            });

            modelBuilder.Entity<TagProject>(entity =>
            {
                entity.HasKey(e => e.ProjectTagId);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TagProject)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TagProject_Project");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.TagProject)
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TagProject_Tag");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.HasIndex(e => new { e.ModifiedData, e.ApprovalStatusId, e.EntityId, e.AssignedTo })
                    .HasName("TaskAssignedToIndex");

                entity.HasIndex(e => new { e.ModifiedData, e.ApprovalStatusId, e.EntityId, e.EntityType })
                    .HasName("IDX_Task_TimeStatus");

                entity.HasIndex(e => new { e.ModifiedData, e.EntityId, e.ApprovalStatusId, e.EntityType })
                    .HasName("IDX_Task_TimeStatus2");

                entity.HasIndex(e => new { e.EntityId, e.AssignedTo, e.ModifiedData, e.ApprovalStatusId, e.EntityType })
                    .HasName("ApprovalStatusEntityType");

                entity.HasIndex(e => new { e.ModifiedData, e.ApprovalStatusId, e.EntityType, e.EntityId, e.TenantId })
                    .HasName("IndexForTimesheetGeneration");

                entity.HasIndex(e => new { e.ModifiedData, e.EntityType, e.EntityId, e.ApprovalStatusId, e.TenantId })
                    .HasName("GenerateTimesheetApproval");

                entity.HasIndex(e => new { e.ApprovalStatusId, e.AssignedTo, e.EntityId, e.EntityType, e.TenantId, e.ModifiedData })
                    .HasName("idxEntityTenantDate");

                entity.HasIndex(e => new { e.AssignedTo, e.ModifiedData, e.ApprovalStatusId, e.TenantId, e.EntityId, e.EntityType })
                    .HasName("nci_wi_Task_DE492E20A01DE0F2A222");

                entity.HasIndex(e => new { e.Comments, e.ModifiedData, e.ApprovalStatusId, e.AssignedTo, e.RequestedBy, e.EntityId })
                    .HasName("TaskEntityIdIndex");

                entity.HasIndex(e => new { e.EntityId, e.ApprovalStatusId, e.EntityType, e.TenantId, e.AssignedTo, e.ModifiedData })
                    .HasName("idxEntityTenantAssignedDate");

                entity.HasIndex(e => new { e.EntityId, e.AssignedTo, e.RequestedBy, e.Comments, e.ModifiedData, e.ApprovalStatusId, e.EntityType })
                    .HasName("IdxEntityTypeVariousColumns");

                entity.HasIndex(e => new { e.EntityId, e.ModifiedData, e.ApprovalStatusId, e.AssignedTo, e.RequestedBy, e.EntityType, e.TenantId })
                    .HasName("EntityTypeTenantIdIndex");

                entity.HasIndex(e => new { e.AssignedTo, e.RequestedBy, e.EntityId, e.InsertDate, e.ModifiedData, e.ApprovalStatusId, e.EntityType, e.TenantId })
                    .HasName("nci_wi_Task_B0DB10B6BBF0CCAF7E7500BCE81B8734");

                entity.HasIndex(e => new { e.InsertDate, e.ApprovalStatusId, e.EntityType, e.EntityId, e.AssignedTo, e.RequestedBy, e.TenantId, e.ModifiedData })
                    .HasName("nci_wi_Task_07FF16869CCD212828CC62034F7AA106");

                entity.HasIndex(e => new { e.InsertDate, e.ModifiedData, e.ApprovalStatusId, e.EntityType, e.EntityId, e.AssignedTo, e.RequestedBy, e.TenantId })
                    .HasName("TaskTenantIdIndex");

                entity.HasIndex(e => new { e.TaskId, e.Comments, e.InsertDate, e.ModifiedData, e.CommentUserId, e.AssignedTo, e.RequestedBy, e.EntityType, e.EntityId, e.ApprovalStatusId, e.TenantId })
                    .HasName("TaskEntriesByDateRangeIndex");

                entity.HasIndex(e => new { e.Comments, e.InsertDate, e.ModifiedData, e.CommentUserId, e.ApprovalStatusId, e.EntityId, e.AssignedTo, e.RequestedBy, e.PriorityId, e.DueDate, e.ApprovalConfigId, e.TenantId, e.EntityType })
                    .HasName("nci_wi_Task_F36BD5BCFF0C87D1D3CAA205648197F4");

                entity.HasIndex(e => new { e.TaskId, e.Comments, e.InsertDate, e.ModifiedData, e.CommentUserId, e.ApprovalStatusId, e.EntityType, e.EntityId, e.AssignedTo, e.RequestedBy, e.PriorityId, e.DueDate, e.TenantId })
                    .HasName("TenantIdIndex");

                entity.HasIndex(e => new { e.TaskId, e.Comments, e.InsertDate, e.ModifiedData, e.CommentUserId, e.AssignedTo, e.RequestedBy, e.PriorityId, e.DueDate, e.EntityType, e.EntityId, e.ApprovalStatusId, e.TenantId })
                    .HasName("IdxApproverStatIdTenantId");

                entity.HasIndex(e => new { e.CommentUserId, e.AssignedTo, e.RequestedBy, e.PriorityId, e.DueDate, e.ApprovalConfigId, e.IgnoreApprovalConfig, e.EntityId, e.Comments, e.InsertDate, e.TenantId, e.EntityType, e.ApprovalStatusId, e.ModifiedData })
                    .HasName("nci_wi_Task_235160DFC8F4213CE7917E91EEE251AD");

                entity.HasIndex(e => new { e.Comments, e.InsertDate, e.ModifiedData, e.CommentUserId, e.ApprovalStatusId, e.RequestedBy, e.PriorityId, e.DueDate, e.ApprovalConfigId, e.IgnoreApprovalConfig, e.EntityId, e.EntityType, e.TenantId, e.AssignedTo })
                    .HasName("nci_wi_Task_0AA2B32B8CFD763BD783F8E8D1A801E3");

                entity.Property(e => e.AssignedTo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Comments).HasMaxLength(500);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.EntityType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedData)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RequestedBy).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.ApprovalStatus)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.ApprovalStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaskStateLog_ApprovalStatus");

                entity.HasOne(d => d.AssignedToNavigation)
                    .WithMany(p => p.TaskAssignedToNavigation)
                    .HasForeignKey(d => d.AssignedTo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Task_Resource");

                entity.HasOne(d => d.CommentUser)
                    .WithMany(p => p.TaskCommentUser)
                    .HasForeignKey(d => d.CommentUserId)
                    .HasConstraintName("FK_TaskStateLog_Resource");

                entity.HasOne(d => d.Priority)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.PriorityId)
                    .HasConstraintName("FK_Task_Priority");

                entity.HasOne(d => d.RequestedByNavigation)
                    .WithMany(p => p.TaskRequestedByNavigation)
                    .HasForeignKey(d => d.RequestedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Task_Resource1");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaskStateLog_Tenant");
            });

            modelBuilder.Entity<TaskHeader>(entity =>
            {
                entity.HasIndex(e => new { e.ApprovalStatusId, e.EntityId, e.EntityType })
                    .HasName("idxTaskHeaderEntityType");

                entity.HasIndex(e => new { e.ApprovalStatusId, e.AssigendTo, e.RequestedBy, e.Comment, e.ModifiedDate, e.EntityType, e.EntityId })
                    .HasName("nci_wi_TaskHeader_32737CFA3FA948F528DE490D40C0B9AA");

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.EntityType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ApprovalConfig)
                    .WithMany(p => p.TaskHeader)
                    .HasForeignKey(d => d.ApprovalConfigId)
                    .HasConstraintName("FK_TaskHeader_ApprovalConfig");

                entity.HasOne(d => d.ApprovalStatus)
                    .WithMany(p => p.TaskHeader)
                    .HasForeignKey(d => d.ApprovalStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaskHeader_ApprovalStatus");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.TaskHeader)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaskHeader_Tenant");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.TeamLeadId).HasColumnName("TeamLeadID");

                entity.Property(e => e.TenantId).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.TeamLead)
                    .WithMany(p => p.Team)
                    .HasForeignKey(d => d.TeamLeadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Team_Resource");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Team)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Team_Tenant");
            });

            modelBuilder.Entity<TemplateHeader>(entity =>
            {
                entity.Property(e => e.ChangedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Competency)
                    .WithMany(p => p.TemplateHeader)
                    .HasForeignKey(d => d.CompetencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TemplateHeader_Competency");

                entity.HasOne(d => d.ProjectType)
                    .WithMany(p => p.TemplateHeader)
                    .HasForeignKey(d => d.ProjectTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TemplateHeader_ProjectType");

                entity.HasOne(d => d.TemplateType)
                    .WithMany(p => p.TemplateHeader)
                    .HasForeignKey(d => d.TemplateTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TemplateHeader_TemplateHeaderType");
            });

            modelBuilder.Entity<TemplateHeaderType>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EnumName)
                    .IsRequired()
                    .HasColumnName("Enum_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplateLine>(entity =>
            {
                entity.Property(e => e.ChangedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.ChangedByNavigation)
                    .WithMany(p => p.TemplateLine)
                    .HasForeignKey(d => d.ChangedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TemplateLine_ChangedByResource");

                entity.HasOne(d => d.TemplateHeader)
                    .WithMany(p => p.TemplateLine)
                    .HasForeignKey(d => d.TemplateHeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TemplateLine_TemplateHeader");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.TemplateLine)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TemplateLine_Tenant");
            });

            modelBuilder.Entity<TemplateLineItem>(entity =>
            {
                entity.Property(e => e.ChangedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.HasOne(d => d.ChangedByNavigation)
                    .WithMany(p => p.TemplateLineItem)
                    .HasForeignKey(d => d.ChangedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TemplateLineItem_ChangedByResource");

                entity.HasOne(d => d.ResourceType)
                    .WithMany(p => p.TemplateLineItem)
                    .HasForeignKey(d => d.ResourceTypeId)
                    .HasConstraintName("FK_TemplateLineItem_ResourceType");

                entity.HasOne(d => d.TemplateLine)
                    .WithMany(p => p.TemplateLineItem)
                    .HasForeignKey(d => d.TemplateLineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TemplateLineItem_TemplateLine");
            });

            modelBuilder.Entity<TemplateType>(entity =>
            {
                entity.HasIndex(e => e.EnumName)
                    .HasName("IX_TemplateType")
                    .IsUnique();

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.EnumName)
                    .IsRequired()
                    .HasColumnName("Enum_Name")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Tenant>(entity =>
            {
                entity.Property(e => e.AddressCity).HasMaxLength(100);

                entity.Property(e => e.AddressCountry).HasMaxLength(100);

                entity.Property(e => e.AddressLine1).HasMaxLength(50);

                entity.Property(e => e.AddressLine2).HasMaxLength(50);

                entity.Property(e => e.AddressPostCode).HasMaxLength(15);

                entity.Property(e => e.EmailAddress).HasMaxLength(200);

                entity.Property(e => e.LastPaymentDate).HasColumnType("date");

                entity.Property(e => e.LogoPath).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.PhoneNumber).HasMaxLength(25);

                entity.Property(e => e.RegNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubscriptionEndDate).HasColumnType("date");

                entity.Property(e => e.Surname).HasMaxLength(200);

                entity.Property(e => e.TenantName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.VatregNo)
                    .HasColumnName("VATRegNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.PricingPlan)
                    .WithMany(p => p.Tenant)
                    .HasForeignKey(d => d.PricingPlanId)
                    .HasConstraintName("FK_Tenant_PricingPlan");
            });

            modelBuilder.Entity<TenantConfig>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Value).IsRequired();

                entity.HasOne(d => d.ConfigKey)
                    .WithMany(p => p.TenantConfig)
                    .HasForeignKey(d => d.ConfigKeyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantConfig_ConfigKey");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.TenantConfig)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantConfig_Tenant");
            });

            modelBuilder.Entity<TenantRule>(entity =>
            {
                entity.Property(e => e.Startdate).HasColumnType("datetime");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TenantRule)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantRule_Product");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.TenantRule)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantRule_Tenant");
            });

            modelBuilder.Entity<Time>(entity =>
            {
                entity.HasIndex(e => new { e.TimeId, e.ProjectMilestoneTaskId })
                    .HasName("MilestoneTaskIndex");

                entity.HasIndex(e => new { e.Date, e.ResourceId, e.TenantId })
                    .HasName("GenerateTimesheetsDateResource");

                entity.HasIndex(e => new { e.Hours, e.ProjectId, e.Date, e.ResourceId })
                    .HasName("IdxHoursProjectIdDate");

                entity.HasIndex(e => new { e.Hours, e.ProjectId, e.ResourceId, e.Date })
                    .HasName("<Name of Missing Index, sysname,>");

                entity.HasIndex(e => new { e.Hours, e.ResourceId, e.TenantId, e.ProjectMilestoneTaskId })
                    .HasName("GenerateTimesheetsResource");

                entity.HasIndex(e => new { e.Hours, e.ProjectId, e.Date, e.ResourceId, e.TenantId })
                    .HasName("idxTimeResourceIdTenantId");

                entity.HasIndex(e => new { e.TimeId, e.Hours, e.ProjectId, e.Date, e.ResourceId, e.TenantId })
                    .HasName("IdxTimeIdHoursProjectIdDateResourceId");

                entity.HasIndex(e => new { e.TimeId, e.Description, e.Hours, e.ResourceId, e.ProjectId, e.TenantId, e.Date })
                    .HasName("IdxProjectTenantIdDate");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DateBilled).HasColumnType("datetime");

                entity.Property(e => e.DateInserted)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Hours).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TenantId).HasDefaultValueSql("((1))");

                entity.Property(e => e.TimeBilled).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Time)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Time_Project");

                entity.HasOne(d => d.ProjectMilestone)
                    .WithMany(p => p.Time)
                    .HasForeignKey(d => d.ProjectMilestoneId)
                    .HasConstraintName("FK_Time_ProjectMilestone");

                entity.HasOne(d => d.ProjectMilestoneTask)
                    .WithMany(p => p.Time)
                    .HasForeignKey(d => d.ProjectMilestoneTaskId)
                    .HasConstraintName("FK_Time_ProjectMilestoneTask");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.Time)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Time_Resource");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Time)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Time_Tenant");
            });

            modelBuilder.Entity<TimeApprovalStatus>(entity =>
            {
                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TimeFrame>(entity =>
            {
                entity.Property(e => e.Frame)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.TimeFrame)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TimeFrame_Tenant");
            });

            modelBuilder.Entity<TimesheetTimer>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.IsResourceTask).HasDefaultValueSql("((0))");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Verification>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpireDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(dateadd(day,(5),getdate()))");
            });

            modelBuilder.Entity<WizardStep>(entity =>
            {
                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.WizardStep)
                    .HasForeignKey(d => d.TemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WizardStep_WizardTemplate");
            });

            modelBuilder.Entity<WizardTemplate>(entity =>
            {
                entity.Property(e => e.ActionIdentifier)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CancelState)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
        }
    }
}
