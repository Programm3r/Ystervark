using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Connection
    {
        public int Id { get; set; }
        public int ResourceId { get; set; }
        public bool IsConnected { get; set; }
        public DateTime Connected { get; set; }
        public string ConnectionId { get; set; }

        public Resource Resource { get; set; }
    }
}
