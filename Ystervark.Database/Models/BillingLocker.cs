using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class BillingLocker
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int TenantId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool IsLocked { get; set; }

        public Client Client { get; set; }
        public Tenant Tenant { get; set; }
    }
}
