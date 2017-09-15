using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class SentEmailHistory
    {
        public int EmailHistoryId { get; set; }
        public string Body { get; set; }
        public string To { get; set; }
        public string Cc { get; set; }
        public string Subject { get; set; }
        public DateTime SentTime { get; set; }
    }
}
