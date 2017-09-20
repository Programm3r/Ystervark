using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;

namespace Ystervark.Repository.Extensions
{
    /// <summary>
    /// Db Data Reader Extension Class
    /// </summary>
    public static class DbDataReaderExtensions
    {
        /// <summary>
        /// Maps to list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dr">The data reader.</param>
        /// <returns></returns>
        public static IList<T> MapToList<T>(this DbDataReader dr)
        {
            var objList = new List<T>();
            var props = typeof(T).GetRuntimeProperties();

            var colMapping = dr.GetColumnSchema()
                .Where(x => props.Any(y => string.Equals(y.Name, x.ColumnName, StringComparison.CurrentCultureIgnoreCase)))
                .ToDictionary(key => key.ColumnName.ToLower());

            if (!dr.HasRows) return objList;
            var propertyInfos = props as IList<PropertyInfo> ?? props.ToList();
            while (dr.Read())
            {
                var obj = Activator.CreateInstance<T>();
                foreach (var prop in propertyInfos)
                {
                    var columnOrdinal = colMapping[prop.Name.ToLower()].ColumnOrdinal;
                    if (columnOrdinal == null) continue;
                    var val = dr.GetValue(columnOrdinal.Value);
                    prop.SetValue(obj, val == DBNull.Value ? null : val);
                }
                objList.Add(obj);
            }
            return objList;
        }
    }
}