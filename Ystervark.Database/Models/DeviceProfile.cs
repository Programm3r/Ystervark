using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class DeviceProfile
    {
        public int Id { get; set; }
        public string DeviceId { get; set; }
        public int ResourceId { get; set; }
        public string Platform { get; set; }

        public Resource Resource { get; set; }
    }
}
