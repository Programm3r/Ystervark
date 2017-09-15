using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class NonWorkingDay
    {
        public int NonWorkingDayId { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        public int TenantId { get; set; }

        public Tenant Tenant { get; set; }
    }
}
