using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class PricingPlan
    {
        public PricingPlan()
        {
            Tenant = new HashSet<Tenant>();
        }

        public int Id { get; set; }
        public int PaymentInterval { get; set; }
        public float Price { get; set; }
        public int ProductId { get; set; }

        public Product Product { get; set; }
        public ICollection<Tenant> Tenant { get; set; }
    }
}
