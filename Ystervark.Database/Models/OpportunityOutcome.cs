using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class OpportunityOutcome
    {
        public OpportunityOutcome()
        {
            Opportunity = new HashSet<Opportunity>();
        }

        public int Id { get; set; }
        public string EnumName { get; set; }
        public string Description { get; set; }

        public ICollection<Opportunity> Opportunity { get; set; }
    }
}
