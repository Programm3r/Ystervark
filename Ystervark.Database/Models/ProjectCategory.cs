using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class ProjectCategory
    {
        public ProjectCategory()
        {
            Project = new HashSet<Project>();
        }

        public int Id { get; set; }
        public string EnumName { get; set; }
        public string Description { get; set; }

        public ICollection<Project> Project { get; set; }
    }
}
