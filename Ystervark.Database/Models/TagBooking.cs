using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class TagBooking
    {
        public int TagBookingId { get; set; }
        public int TagId { get; set; }
        public int BookingId { get; set; }

        public Booking Booking { get; set; }
        public Tag Tag { get; set; }
    }
}
