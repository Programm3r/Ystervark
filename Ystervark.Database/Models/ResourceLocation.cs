using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class ResourceLocation
    {
        public int Id { get; set; }
        public int ResourceId { get; set; }
        public int TenantId { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime? TimeStamp { get; set; }

        public Resource Resource { get; set; }
        public Tenant Tenant { get; set; }
    }
}
