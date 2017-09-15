using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class ProductLicense
    {
        public int ProductLicenseId { get; set; }
        public int ProductId { get; set; }
        public int LicenseTypeId { get; set; }

        public LicenseType LicenseType { get; set; }
        public Product Product { get; set; }
    }
}
