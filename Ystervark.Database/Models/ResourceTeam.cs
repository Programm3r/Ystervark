using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class ResourceTeam
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public int ResourceId { get; set; }

        public Resource Resource { get; set; }
        public Team Team { get; set; }
    }
}
