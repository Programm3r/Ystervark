using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class TenantConfig
    {
        public int Id { get; set; }
        public int TenantId { get; set; }
        public int ConfigKeyId { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }

        public ConfigKey ConfigKey { get; set; }
        public Tenant Tenant { get; set; }
    }
}
