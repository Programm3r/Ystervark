using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Address
    {
        public Address()
        {
            ClientPhysicalAddress = new HashSet<Client>();
            ClientPostalAddress = new HashSet<Client>();
            ClientSite = new HashSet<ClientSite>();
            Resource = new HashSet<Resource>();
        }

        public int Id { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int CountryId { get; set; }
        public string Code { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string Line1 { get; set; }

        public Country Country { get; set; }
        public ICollection<Client> ClientPhysicalAddress { get; set; }
        public ICollection<Client> ClientPostalAddress { get; set; }
        public ICollection<ClientSite> ClientSite { get; set; }
        public ICollection<Resource> Resource { get; set; }
    }
}
