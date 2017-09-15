using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class InvoiceProject
    {
        public InvoiceProject()
        {
            CreditNoteProject = new HashSet<CreditNoteProject>();
            InvoiceLine = new HashSet<InvoiceLine>();
        }

        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public int ProjectId { get; set; }
        public int? QuoteId { get; set; }

        public Invoice Invoice { get; set; }
        public Project Project { get; set; }
        public Quote Quote { get; set; }
        public ICollection<CreditNoteProject> CreditNoteProject { get; set; }
        public ICollection<InvoiceLine> InvoiceLine { get; set; }
    }
}
