using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class ConfigKey
    {
        public ConfigKey()
        {
            ConfigSetup = new HashSet<ConfigSetup>();
            TenantConfig = new HashSet<TenantConfig>();
        }

        public int Id { get; set; }
        public string EnumName { get; set; }
        public string Description { get; set; }
        public string DataType { get; set; }

        public ICollection<ConfigSetup> ConfigSetup { get; set; }
        public ICollection<TenantConfig> TenantConfig { get; set; }
    }
}
