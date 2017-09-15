using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Expense
    {
        public Expense()
        {
            AttachmentLink = new HashSet<AttachmentLink>();
            ExpenseException = new HashSet<ExpenseException>();
        }

        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int ExpenseCategoryId { get; set; }
        public int ResourceId { get; set; }
        public DateTime ExpenseDate { get; set; }
        public string Comments { get; set; }
        public decimal Amount { get; set; }
        public bool? IsBillable { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int TenantId { get; set; }
        public bool? IsApproved { get; set; }
        public bool? IsRefundable { get; set; }
        public bool? IsProcessed { get; set; }
        public DateTime? ProcessDate { get; set; }
        public decimal? ProcessAmount { get; set; }
        public int? ProcessedBy { get; set; }
        public int? TransactionId { get; set; }

        public ExpenseCategory ExpenseCategory { get; set; }
        public Project Project { get; set; }
        public Resource Resource { get; set; }
        public Tenant Tenant { get; set; }
        public ExpenseTransaction Transaction { get; set; }
        public ICollection<AttachmentLink> AttachmentLink { get; set; }
        public ICollection<ExpenseException> ExpenseException { get; set; }
    }
}
