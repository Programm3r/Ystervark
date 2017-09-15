using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Coupon
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public DateTime? Expiry { get; set; }
        public bool Redeem { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? TenantId { get; set; }

        public Resource CreatedByNavigation { get; set; }
        public Tenant Tenant { get; set; }
    }
}
