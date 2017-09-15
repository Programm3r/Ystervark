using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class ProductRule
    {
        public ProductRule()
        {
            Licence = new HashSet<Licence>();
        }

        public int ProductRuleId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int? TimeValid { get; set; }

        public Product Product { get; set; }
        public ICollection<Licence> Licence { get; set; }
    }
}
