using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Team
    {
        public Team()
        {
            Project = new HashSet<Project>();
            ResourceTeam = new HashSet<ResourceTeam>();
        }

        public int TeamId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public int TeamLeadId { get; set; }
        public int TenantId { get; set; }

        public Resource TeamLead { get; set; }
        public Tenant Tenant { get; set; }
        public ICollection<Project> Project { get; set; }
        public ICollection<ResourceTeam> ResourceTeam { get; set; }
    }
}
