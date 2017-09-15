using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class StorageProvider
    {
        public int Id { get; set; }
        public string EnumName { get; set; }
        public string Description { get; set; }
    }
}
