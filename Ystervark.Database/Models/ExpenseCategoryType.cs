using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class ExpenseCategoryType
    {
        public ExpenseCategoryType()
        {
            ExpenseCategory = new HashSet<ExpenseCategory>();
        }

        public int Id { get; set; }
        public decimal Unit { get; set; }
        public string UnitOfMeasure { get; set; }

        public ICollection<ExpenseCategory> ExpenseCategory { get; set; }
    }
}
