using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Licence
    {
        public int LicenceId { get; set; }
        public int ProductRuleId { get; set; }
        public int TenantId { get; set; }
        public int? ResourceId { get; set; }
        public int LicenceTypeId { get; set; }
        public int? Enabled { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public LicenseType LicenceType { get; set; }
        public ProductRule ProductRule { get; set; }
        public Resource Resource { get; set; }
        public Tenant Tenant { get; set; }
    }
}
