using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Journey
    {
        public Journey()
        {
            JourneyRoute = new HashSet<JourneyRoute>();
        }

        public int Id { get; set; }
        public DateTime TravelDate { get; set; }
        public double TotalDistance { get; set; }
        public double OriginLatitude { get; set; }
        public double OriginLongitude { get; set; }
        public double DestinationLatitude { get; set; }
        public double DestinationLongitude { get; set; }
        public int ResourceId { get; set; }
        public double OriginToTenantDistance { get; set; }
        public double DestinationToTenantDistance { get; set; }

        public Resource Resource { get; set; }
        public ICollection<JourneyRoute> JourneyRoute { get; set; }
    }
}
