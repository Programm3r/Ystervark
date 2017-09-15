using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class ClientType
    {
        public int ClientTypeId { get; set; }
        public int TenantId { get; set; }
        public string Description { get; set; }

        public Tenant Tenant { get; set; }
    }
}
