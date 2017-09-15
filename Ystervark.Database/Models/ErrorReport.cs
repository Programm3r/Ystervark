using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class ErrorReport
    {
        public int ErrorReportId { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public DateTime TimeStamp { get; set; }
        public string User { get; set; }
        public string PayLoad { get; set; }
    }
}
