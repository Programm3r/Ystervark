using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class InvoiceLine
    {
        public InvoiceLine()
        {
            CreditNoteLine = new HashSet<CreditNoteLine>();
            InvoiceLineItem = new HashSet<InvoiceLineItem>();
        }

        public int Id { get; set; }
        public int InvoiceProjectId { get; set; }
        public int? ProjectMileStoneId { get; set; }
        public string Description { get; set; }

        public InvoiceProject InvoiceProject { get; set; }
        public ProjectMilestone ProjectMileStone { get; set; }
        public ICollection<CreditNoteLine> CreditNoteLine { get; set; }
        public ICollection<InvoiceLineItem> InvoiceLineItem { get; set; }
    }
}
