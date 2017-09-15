using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Skill
    {
        public Skill()
        {
            CompetencySkill = new HashSet<CompetencySkill>();
            ResourceSkill = new HashSet<ResourceSkill>();
        }

        public int SkillId { get; set; }
        public string Description { get; set; }
        public int TenantId { get; set; }

        public Tenant Tenant { get; set; }
        public ICollection<CompetencySkill> CompetencySkill { get; set; }
        public ICollection<ResourceSkill> ResourceSkill { get; set; }
    }
}
