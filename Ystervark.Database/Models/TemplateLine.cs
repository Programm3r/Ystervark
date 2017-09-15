using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class TemplateLine
    {
        public TemplateLine()
        {
            TemplateLineItem = new HashSet<TemplateLineItem>();
        }

        public int Id { get; set; }
        public int TemplateHeaderId { get; set; }
        public string Description { get; set; }
        public int ChangedBy { get; set; }
        public DateTime ChangedOn { get; set; }
        public int TenantId { get; set; }

        public Resource ChangedByNavigation { get; set; }
        public TemplateHeader TemplateHeader { get; set; }
        public Tenant Tenant { get; set; }
        public ICollection<TemplateLineItem> TemplateLineItem { get; set; }
    }
}
