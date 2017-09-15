using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class OpportunitySource
    {
        public OpportunitySource()
        {
            Opportunity = new HashSet<Opportunity>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TenantId { get; set; }

        public Tenant Tenant { get; set; }
        public ICollection<Opportunity> Opportunity { get; set; }
    }
}
