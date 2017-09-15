using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class ResourceBankDetail
    {
        public ResourceBankDetail()
        {
            Resource = new HashSet<Resource>();
        }

        public int Id { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string BranchCode { get; set; }
        public string AccountNo { get; set; }
        public string AccountName { get; set; }

        public ICollection<Resource> Resource { get; set; }
    }
}
