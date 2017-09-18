using System.Threading.Tasks;
using Ystervark.Database.Models;
using Ystervark.Manager.Base;
using Ystervark.Models.DTO;

namespace Ystervark.Manager.Interface
{
    /// <summary>
    /// Region Manager Interface
    /// </summary>
    /// <seealso cref="Ystervark.Manager.Base.IBaseManager" />
    public interface IRegionManager : IBaseManager
    {
        /// <summary>
        /// Inserts the specified region.
        /// </summary>
        /// <param name="region">The region.</param>
        /// <returns></returns>
        Task<Region> Insert(RegionModel region);

        /// <summary>
        /// Updates the specified region.
        /// </summary>
        /// <param name="region">The region.</param>
        /// <returns></returns>
        Task<Region> Update(RegionModel region);
    }
}