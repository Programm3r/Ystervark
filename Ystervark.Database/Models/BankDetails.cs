using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class BankDetails
    {
        public int Id { get; set; }
        public int TenantId { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string BranchCode { get; set; }
        public string AccountNo { get; set; }
        public string AccountName { get; set; }

        public Tenant Tenant { get; set; }
    }
}
