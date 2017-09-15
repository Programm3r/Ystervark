using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class CreditNoteProject
    {
        public CreditNoteProject()
        {
            CreditNoteLine = new HashSet<CreditNoteLine>();
        }

        public int Id { get; set; }
        public int CreditNoteId { get; set; }
        public int InvoiceProjectId { get; set; }
        public string ProjectName { get; set; }

        public CreditNote CreditNote { get; set; }
        public InvoiceProject InvoiceProject { get; set; }
        public ICollection<CreditNoteLine> CreditNoteLine { get; set; }
    }
}
