using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class BatchNumber
    {
        public string Batch { get; set; }
        public string UniqueKey { get; set; }
        public int TenantId { get; set; }
    }
}
