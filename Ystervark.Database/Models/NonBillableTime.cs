using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class NonBillableTime
    {
        public int Id { get; set; }
        public int TimeId { get; set; }
        public bool? NonBillable { get; set; }
        public int CreatedByResourceId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedByResourceId { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public Resource CreatedByResource { get; set; }
        public Time Time { get; set; }
        public Resource UpdatedByResource { get; set; }
    }
}
