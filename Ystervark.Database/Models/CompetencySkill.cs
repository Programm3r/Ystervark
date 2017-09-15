using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class CompetencySkill
    {
        public int CompetencySkillId { get; set; }
        public int CompetencyId { get; set; }
        public int SkillId { get; set; }

        public Competency Competency { get; set; }
        public Skill Skill { get; set; }
    }
}
