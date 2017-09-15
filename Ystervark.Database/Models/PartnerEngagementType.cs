using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class PartnerEngagementType
    {
        public PartnerEngagementType()
        {
            PartnerMargin = new HashSet<PartnerMargin>();
        }

        public int PartnerEngagementTypeId { get; set; }
        public int TenantId { get; set; }
        public string Description { get; set; }

        public ICollection<PartnerMargin> PartnerMargin { get; set; }
    }
}
