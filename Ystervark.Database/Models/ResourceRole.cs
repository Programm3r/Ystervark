using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class ResourceRole
    {
        public int ResourceRoleId { get; set; }
        public int ResourceId { get; set; }
        public int RoleId { get; set; }

        public Resource Resource { get; set; }
        public Role Role { get; set; }
    }
}
