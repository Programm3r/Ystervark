using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class MessageGroupMembers
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int GroupId { get; set; }
        public bool IsAdmin { get; set; }

        public MessageGroup Group { get; set; }
        public Resource Member { get; set; }
    }
}
