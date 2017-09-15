using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class ResourceRate
    {
        public int Id { get; set; }
        public int ResourceId { get; set; }
        public DateTime EffectiveDate { get; set; }
        public decimal Rate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedByResourceId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedByResourceId { get; set; }
        public int TenantId { get; set; }

        public Resource CreatedByResource { get; set; }
        public Resource Resource { get; set; }
        public Tenant Tenant { get; set; }
        public Resource UpdatedByResource { get; set; }
    }
}
