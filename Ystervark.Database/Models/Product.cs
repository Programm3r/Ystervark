using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Product
    {
        public Product()
        {
            PricingPlan = new HashSet<PricingPlan>();
            ProductLicense = new HashSet<ProductLicense>();
            ProductRule = new HashSet<ProductRule>();
            TenantRule = new HashSet<TenantRule>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<PricingPlan> PricingPlan { get; set; }
        public ICollection<ProductLicense> ProductLicense { get; set; }
        public ICollection<ProductRule> ProductRule { get; set; }
        public ICollection<TenantRule> TenantRule { get; set; }
    }
}
