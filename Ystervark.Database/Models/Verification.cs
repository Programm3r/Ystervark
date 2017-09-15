using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Verification
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public bool Verified { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ExpireDate { get; set; }
    }
}
