using System;
using System.Collections.Generic;

namespace Ystervark.Database.Models
{
    public partial class Priority
    {
        public Priority()
        {
            Task = new HashSet<Task>();
        }

        public int Id { get; set; }
        public string EnumName { get; set; }
        public string Description { get; set; }

        public ICollection<Task> Task { get; set; }
    }
}
