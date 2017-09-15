using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class JourneyRoute
    {
        public int Id { get; set; }
        public int JourneyId { get; set; }
        public int WayPointIndex { get; set; }
        public string OriginLabel { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string DestinationLabel { get; set; }
        public double OriginLatitude { get; set; }
        public double OriginLongitude { get; set; }
        public double DestinationLatitude { get; set; }
        public double DestinationLongitude { get; set; }

        public Journey Journey { get; set; }
    }
}
