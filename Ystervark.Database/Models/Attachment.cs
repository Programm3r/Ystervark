using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Attachment
    {
        public Attachment()
        {
            AttachmentLink = new HashSet<AttachmentLink>();
        }

        public int Id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public long? Size { get; set; }
        public string Type { get; set; }
        public DateTime? LastModifiedDate { get; set; }

        public ICollection<AttachmentLink> AttachmentLink { get; set; }
    }
}
