using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Ystervark.Database.Models
{
    /// <summary>
    /// Briteplan DB Context Developer Class
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public partial class Briteplan
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Briteplan"/> class.
        /// </summary>
        /// <param name="options">The options for this context.</param>
        public Briteplan(DbContextOptions options) : base(options)
        {
            
        }
    }
}
