using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class TimeFrame
    {
        public TimeFrame()
        {
            Opportunity = new HashSet<Opportunity>();
        }

        public int Id { get; set; }
        public string Frame { get; set; }
        public int TenantId { get; set; }

        public Tenant Tenant { get; set; }
        public ICollection<Opportunity> Opportunity { get; set; }
    }
}
