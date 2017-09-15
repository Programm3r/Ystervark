using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class OpportunityRating
    {
        public OpportunityRating()
        {
            Opportunity = new HashSet<Opportunity>();
        }

        public int Id { get; set; }
        public string Rating { get; set; }

        public ICollection<Opportunity> Opportunity { get; set; }
    }
}
