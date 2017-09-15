using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class ResourceType
    {
        public ResourceType()
        {
            QuoteLineItem = new HashSet<QuoteLineItem>();
            QuoteRate = new HashSet<QuoteRate>();
            Resource = new HashSet<Resource>();
            TemplateLineItem = new HashSet<TemplateLineItem>();
        }

        public int ResourceTypeId { get; set; }
        public int TenantId { get; set; }
        public string Name { get; set; }

        public Tenant Tenant { get; set; }
        public ICollection<QuoteLineItem> QuoteLineItem { get; set; }
        public ICollection<QuoteRate> QuoteRate { get; set; }
        public ICollection<Resource> Resource { get; set; }
        public ICollection<TemplateLineItem> TemplateLineItem { get; set; }
    }
}
