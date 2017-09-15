using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class ContactType
    {
        public ContactType()
        {
            ContactTypeMap = new HashSet<ContactTypeMap>();
        }

        public int Id { get; set; }
        public string EnumName { get; set; }
        public string Description { get; set; }

        public ICollection<ContactTypeMap> ContactTypeMap { get; set; }
    }
}
