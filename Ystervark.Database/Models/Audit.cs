using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Audit
    {
        public long Id { get; set; }
        public string TableName { get; set; }
        public int RecordId { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string ColumnName { get; set; }
        public int ResourceId { get; set; }
        public DateTime DateStamp { get; set; }
        public string Action { get; set; }
    }
}
