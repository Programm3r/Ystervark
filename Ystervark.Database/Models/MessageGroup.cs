using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class MessageGroup
    {
        public MessageGroup()
        {
            MessageGroupMembers = new HashSet<MessageGroupMembers>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public ICollection<MessageGroupMembers> MessageGroupMembers { get; set; }
    }
}
