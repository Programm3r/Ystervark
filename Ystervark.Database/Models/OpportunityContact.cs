using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class OpportunityContact
    {
        public int Id { get; set; }
        public int OpportunityId { get; set; }
        public int ContactId { get; set; }

        public Contact Contact { get; set; }
        public Opportunity Opportunity { get; set; }
    }
}
