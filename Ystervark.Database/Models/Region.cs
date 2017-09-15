using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Region
    {
        public Region()
        {
            Client = new HashSet<Client>();
            Opportunity = new HashSet<Opportunity>();
            Resource = new HashSet<Resource>();
        }

        public int RegionId { get; set; }
        public int TenantId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Tenant Tenant { get; set; }
        public ICollection<Client> Client { get; set; }
        public ICollection<Opportunity> Opportunity { get; set; }
        public ICollection<Resource> Resource { get; set; }
    }
}
