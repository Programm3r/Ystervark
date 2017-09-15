using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class ResourceSkillHistory
    {
        public int Id { get; set; }
        public int ResourceId { get; set; }
        public int SkillId { get; set; }
        public int SkillLevel { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
