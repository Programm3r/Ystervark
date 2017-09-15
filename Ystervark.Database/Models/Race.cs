using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Race
    {
        public int RaceId { get; set; }
        public int TenantId { get; set; }
        public string RaceName { get; set; }
    }
}
