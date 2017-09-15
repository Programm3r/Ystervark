using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Messages
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public int From { get; set; }
        public int To { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool? Read { get; set; }
        public DateTime? DateRead { get; set; }
        public bool? IsGroupMessage { get; set; }
        public int? GroupId { get; set; }

        public Resource FromNavigation { get; set; }
        public Resource ToNavigation { get; set; }
    }
}
