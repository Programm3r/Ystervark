using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class ClientSite
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ClientId { get; set; }
        public int AddressId { get; set; }
        public string AccountNumber { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public Address Address { get; set; }
        public Client Client { get; set; }
    }
}
