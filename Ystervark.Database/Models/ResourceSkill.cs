using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class ResourceSkill
    {
        public int Id { get; set; }
        public int ResourceId { get; set; }
        public int SkillId { get; set; }
        public int SkillLevel { get; set; }

        public Resource Resource { get; set; }
        public Skill Skill { get; set; }
    }
}
