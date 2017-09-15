using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Competency
    {
        public Competency()
        {
            CompetencySkill = new HashSet<CompetencySkill>();
            Opportunity = new HashSet<Opportunity>();
            Project = new HashSet<Project>();
            Quote = new HashSet<Quote>();
            TemplateHeader = new HashSet<TemplateHeader>();
        }

        public int CompetencyId { get; set; }
        public int TenantId { get; set; }
        public string CompetencyName { get; set; }
        public int? CompetencyLeadId { get; set; }
        public int? Blocked { get; set; }
        public bool? Archived { get; set; }
        public int? ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }

        public Resource CompetencyLead { get; set; }
        public Tenant Tenant { get; set; }
        public ICollection<CompetencySkill> CompetencySkill { get; set; }
        public ICollection<Opportunity> Opportunity { get; set; }
        public ICollection<Project> Project { get; set; }
        public ICollection<Quote> Quote { get; set; }
        public ICollection<TemplateHeader> TemplateHeader { get; set; }
    }
}
