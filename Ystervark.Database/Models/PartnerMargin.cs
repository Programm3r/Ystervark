using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class PartnerMargin
    {
        public int PartnerMarginId { get; set; }
        public int PartnerId { get; set; }
        public int PartnerEngagementTypeId { get; set; }
        public decimal ThresholdMin { get; set; }
        public decimal ThresholdMax { get; set; }
        public int MarginPercentage { get; set; }
        public decimal BaseCostPerHour { get; set; }
        public DateTime DateInserted { get; set; }

        public Partner Partner { get; set; }
        public PartnerEngagementType PartnerEngagementType { get; set; }
        public PartnerMargin PartnerMarginNavigation { get; set; }
        public PartnerMargin InversePartnerMarginNavigation { get; set; }
    }
}
