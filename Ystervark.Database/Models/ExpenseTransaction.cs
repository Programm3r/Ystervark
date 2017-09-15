using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class ExpenseTransaction
    {
        public ExpenseTransaction()
        {
            Expense = new HashSet<Expense>();
        }

        public int Id { get; set; }
        public decimal Unit { get; set; }
        public string UnitOfMeasure { get; set; }
        public decimal UnitValue { get; set; }
        public decimal CalculatedUnit { get; set; }

        public ICollection<Expense> Expense { get; set; }
    }
}
