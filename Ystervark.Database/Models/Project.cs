using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Project
    {
        public Project()
        {
            AttachmentLink = new HashSet<AttachmentLink>();
            Booking = new HashSet<Booking>();
            Expense = new HashSet<Expense>();
            InvoiceProject = new HashSet<InvoiceProject>();
            ProjectComment = new HashSet<ProjectComment>();
            ProjectMilestone = new HashSet<ProjectMilestone>();
            ProjectRate = new HashSet<ProjectRate>();
            ProjectResourceLink = new HashSet<ProjectResourceLink>();
            Quote = new HashSet<Quote>();
            TagProject = new HashSet<TagProject>();
            Time = new HashSet<Time>();
        }

        public int ProjectId { get; set; }
        public int ClientId { get; set; }
        public int TenantId { get; set; }
        public string ProjectName { get; set; }
        public int? BudgetedHours { get; set; }
        public bool? Archived { get; set; }
        public string Description { get; set; }
        public DateTime? CompletionDate { get; set; }
        public bool? IsOverTime { get; set; }
        public int? ProjectMangerId { get; set; }
        public int? CompetencyId { get; set; }
        public int? ProjectTypeId { get; set; }
        public string Ponumber { get; set; }
        public DateTime? StartDate { get; set; }
        public int? TeamId { get; set; }
        public decimal? NotifyOnTimeLimit { get; set; }
        public decimal? BudgetedAmount { get; set; }
        public int ProjectCategoryId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public Client Client { get; set; }
        public Competency Competency { get; set; }
        public Resource CreatedByNavigation { get; set; }
        public ProjectCategory ProjectCategory { get; set; }
        public Resource ProjectManger { get; set; }
        public ProjectType ProjectType { get; set; }
        public Team Team { get; set; }
        public Tenant Tenant { get; set; }
        public Resource UpdatedByNavigation { get; set; }
        public ICollection<AttachmentLink> AttachmentLink { get; set; }
        public ICollection<Booking> Booking { get; set; }
        public ICollection<Expense> Expense { get; set; }
        public ICollection<InvoiceProject> InvoiceProject { get; set; }
        public ICollection<ProjectComment> ProjectComment { get; set; }
        public ICollection<ProjectMilestone> ProjectMilestone { get; set; }
        public ICollection<ProjectRate> ProjectRate { get; set; }
        public ICollection<ProjectResourceLink> ProjectResourceLink { get; set; }
        public ICollection<Quote> Quote { get; set; }
        public ICollection<TagProject> TagProject { get; set; }
        public ICollection<Time> Time { get; set; }
    }
}
