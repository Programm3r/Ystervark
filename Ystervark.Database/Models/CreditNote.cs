using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class CreditNote
    {
        public CreditNote()
        {
            CreditNoteProject = new HashSet<CreditNoteProject>();
        }

        public int Id { get; set; }
        public string CreditNoteNumber { get; set; }
        public int InvoiceId { get; set; }
        public DateTime? Date { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedByResourceId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedByResourceId { get; set; }
        public bool? Archived { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public decimal Vat { get; set; }
        public string AltReference { get; set; }

        public Resource CreatedByResource { get; set; }
        public Invoice Invoice { get; set; }
        public Resource UpdatedByResource { get; set; }
        public ICollection<CreditNoteProject> CreditNoteProject { get; set; }
    }
}
