using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class ExpenseException
    {
        public int Id { get; set; }
        public int ExpenseId { get; set; }
        public string Exception { get; set; }

        public Expense Expense { get; set; }
    }
}
