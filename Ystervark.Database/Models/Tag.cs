using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Tag
    {
        public Tag()
        {
            TagBooking = new HashSet<TagBooking>();
            TagProject = new HashSet<TagProject>();
        }

        public int TagId { get; set; }
        public string Name { get; set; }
        public int TenantId { get; set; }

        public ICollection<TagBooking> TagBooking { get; set; }
        public ICollection<TagProject> TagProject { get; set; }
    }
}
