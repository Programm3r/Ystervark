using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Partner
    {
        public Partner()
        {
            PartnerMargin = new HashSet<PartnerMargin>();
        }

        public int PartnerId { get; set; }
        public int TenantId { get; set; }
        public string Name { get; set; }

        public Tenant Tenant { get; set; }
        public ICollection<PartnerMargin> PartnerMargin { get; set; }
    }
}
