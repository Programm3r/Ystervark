using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Country
    {
        public Country()
        {
            Address = new HashSet<Address>();
        }

        public int Id { get; set; }
        public string Iso { get; set; }
        public string Name { get; set; }
        public string AltName { get; set; }
        public string Iso3 { get; set; }
        public short? NumCode { get; set; }
        public int PhoneCode { get; set; }

        public ICollection<Address> Address { get; set; }
    }
}
