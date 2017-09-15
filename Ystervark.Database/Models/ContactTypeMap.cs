using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class ContactTypeMap
    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        public int ContactTypeId { get; set; }

        public Contact Contact { get; set; }
        public ContactType ContactType { get; set; }
    }
}
