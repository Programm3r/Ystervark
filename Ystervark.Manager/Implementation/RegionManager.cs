using System.Threading.Tasks;
using Ystervark.Database.Models;
using Ystervark.Manager.Base;
using Ystervark.Manager.Interface;
using Ystervark.Models.DTO;
using Ystervark.Repository.Interface;

namespace Ystervark.Manager.Implementation
{
    /// <summary>
    /// Region Manager Class
    /// </summary>
    /// <seealso cref="Ystervark.Manager.Base.BaseManager" />
    /// <seealso cref="Ystervark.Manager.Interface.IRegionManager" />
    public class RegionManager : BaseManager, IRegionManager
    {
        #region RegionManager - Repository Properties

        /// <summary>
        /// Gets the region repository.
        /// </summary>
        /// <value>
        /// The region repository.
        /// </value>
        public IRepository<Region> RegionRepository => base.UnitOfWork.GetRepository<Region>();

        #endregion

        #region Implementation of IRegionManager

        /// <summary>
        /// Inserts the specified region.
        /// </summary>
        /// <param name="region">The region.</param>
        /// <returns></returns>
        public async Task<Region> Insert(RegionModel region)
        {
            var newRegion = this.RegionRepository.Insert(Mapper.Map<Region>(region));
            await base.UnitOfWork.SaveChangesAsync();
            return newRegion;
        }

        /// <summary>
        /// Updates the specified region.
        /// </summary>
        /// <param name="region">The region.</param>
        /// <returns></returns>
        public async Task<Region> Update(RegionModel region)
        {
            var updatedRegion = this.RegionRepository.Update(Mapper.Map<Region>(region));
            await base.UnitOfWork.SaveChangesAsync();
            return updatedRegion;
        }

        #endregion
    }
}