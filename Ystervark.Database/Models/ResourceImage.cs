using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class ResourceImage
    {
        public int ResourceId { get; set; }
        public string Image { get; set; }

        public Resource Resource { get; set; }
    }
}
