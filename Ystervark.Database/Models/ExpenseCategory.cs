using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class ExpenseCategory
    {
        public ExpenseCategory()
        {
            Expense = new HashSet<Expense>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string Glcode { get; set; }
        public int? ExpenseCategoryTypeId { get; set; }
        public bool? Archived { get; set; }
        public int TenantId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public ExpenseCategoryType ExpenseCategoryType { get; set; }
        public Tenant Tenant { get; set; }
        public ICollection<Expense> Expense { get; set; }
    }
}
