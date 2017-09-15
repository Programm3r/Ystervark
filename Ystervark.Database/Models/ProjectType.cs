using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class ProjectType
    {
        public ProjectType()
        {
            Project = new HashSet<Project>();
            Quote = new HashSet<Quote>();
            QuoteRate = new HashSet<QuoteRate>();
            TemplateHeader = new HashSet<TemplateHeader>();
        }

        public int ProjectTypeId { get; set; }
        public int TenantId { get; set; }
        public string ProjectTypeName { get; set; }

        public Tenant Tenant { get; set; }
        public ICollection<Project> Project { get; set; }
        public ICollection<Quote> Quote { get; set; }
        public ICollection<QuoteRate> QuoteRate { get; set; }
        public ICollection<TemplateHeader> TemplateHeader { get; set; }
    }
}
