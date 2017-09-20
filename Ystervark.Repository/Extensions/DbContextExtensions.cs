using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Ystervark.Repository.Extensions
{
    /// <summary>
    /// Db Context Extension Class
    /// </summary>
    public static class DbContextExtensions
    {
        /// <summary>
        /// Loads the stored procedure.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="storedProcName">Name of the stored procedure.</param>
        /// <returns></returns>
        public static DbCommand LoadStoredProc(this DbContext context, string storedProcName)
        {
            var cmd = context.Database.GetDbConnection().CreateCommand();
            cmd.CommandText = storedProcName;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            return cmd;
        }
    }
}