using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class TemplateHeaderType
    {
        public TemplateHeaderType()
        {
            TemplateHeader = new HashSet<TemplateHeader>();
        }

        public int Id { get; set; }
        public string EnumName { get; set; }
        public string Description { get; set; }

        public ICollection<TemplateHeader> TemplateHeader { get; set; }
    }
}
