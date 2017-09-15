using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class TemplateLineItem
    {
        public int Id { get; set; }
        public int TemplateLineId { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Rate { get; set; }
        public int? ResourceTypeId { get; set; }
        public int ChangedBy { get; set; }
        public DateTime ChangedOn { get; set; }

        public Resource ChangedByNavigation { get; set; }
        public ResourceType ResourceType { get; set; }
        public TemplateLine TemplateLine { get; set; }
    }
}
