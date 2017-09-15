using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class LicenseType
    {
        public LicenseType()
        {
            Licence = new HashSet<Licence>();
            ProductLicense = new HashSet<ProductLicense>();
        }

        public int LicenseTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Licence> Licence { get; set; }
        public ICollection<ProductLicense> ProductLicense { get; set; }
    }
}
