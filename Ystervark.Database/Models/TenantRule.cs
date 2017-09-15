using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class TenantRule
    {
        public int TenantRuleId { get; set; }
        public int TenantId { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public DateTime? Startdate { get; set; }

        public Product Product { get; set; }
        public Tenant Tenant { get; set; }
    }
}
