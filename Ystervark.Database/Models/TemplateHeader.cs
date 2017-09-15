using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class TemplateHeader
    {
        public TemplateHeader()
        {
            TemplateLine = new HashSet<TemplateLine>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int TemplateTypeId { get; set; }
        public int CompetencyId { get; set; }
        public int ProjectTypeId { get; set; }
        public int TenantId { get; set; }
        public int ChangedBy { get; set; }
        public DateTime ChangedOn { get; set; }

        public Competency Competency { get; set; }
        public ProjectType ProjectType { get; set; }
        public TemplateHeaderType TemplateType { get; set; }
        public ICollection<TemplateLine> TemplateLine { get; set; }
    }
}
