using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class ClientContact
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ContactId { get; set; }

        public Client Client { get; set; }
        public Contact Contact { get; set; }
    }
}
