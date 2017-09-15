using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class QuoteRate
    {
        public int QuoteRateId { get; set; }
        public int TenantId { get; set; }
        public int ResourceTypeId { get; set; }
        public decimal RatePerHour { get; set; }
        public string Currency { get; set; }
        public DateTime DateFrom { get; set; }
        public bool? IsActive { get; set; }
        public int ProjectTypeId { get; set; }

        public ProjectType ProjectType { get; set; }
        public ResourceType ResourceType { get; set; }
        public Tenant Tenant { get; set; }
    }
}
