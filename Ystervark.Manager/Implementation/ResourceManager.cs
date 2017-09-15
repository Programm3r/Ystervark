using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ystervark.Database.Models;
using Ystervark.Manager.Base;
using Ystervark.Manager.Helpers;
using Ystervark.Manager.Interface;
using Ystervark.Models.DTO;
using Ystervark.Repository.Interface;

namespace Ystervark.Manager.Implementation
{
    /// <summary>
    /// Resource Manager Class Declaration 
    /// </summary>
    /// <seealso cref="BaseManager" />
    /// <seealso cref="IResourceManager" />
    public class ResourceManager : BaseManager, IResourceManager
    {
        #region ResourceManager - Repository Properties

        /// <summary>
        /// Gets the resource repository.
        /// </summary>
        /// <value>
        /// The resource repository.
        /// </value>
        public IRepository<Resource> ResourceRepository => base.UnitOfWork.GetRepository<Resource>();

        #endregion

        #region Implementation of IResourceManager

        /// <summary>
        /// Authenticates the resource.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public async Task<ResourceModel> AuthenticateResource(string username, string password)
        {
            var pwd = Md5Helper.GetMd5Hash(password);
            return Mapper.Map<ResourceModel>(await this.ResourceRepository.FindAsync(f => f.ResourceName == username && f.Password == pwd,
                i => i.Include(x => x.ResourceRole).ThenInclude(rr => rr.Role)));
        }

        /// <summary>
        /// Gets all resource data.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ResourceModel>> GetAllResourceData()
        {
            var dbResponse = await this.ResourceRepository.GetPagedListAsync(null, null, f => f.Include(q => q.ResourceRole));
            return Mapper.Map<IEnumerable<ResourceModel>>(dbResponse.Items);
        }

        /// <summary>
        /// Gets the resource by identifier.
        /// </summary>
        /// <param name="resourceId">The resource identifier.</param>
        /// <returns></returns>
        public async Task<ResourceModel> GetResourceById(int resourceId) =>
            Mapper.Map<ResourceModel>(await this.ResourceRepository.FindAsync(f => f.ResourceId == resourceId));

        /// <summary>
        /// Gets the resource by username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
        public async Task<ResourceModel> GetResourceByUsername(string username)
        {
            return Mapper.Map<ResourceModel>(await this.ResourceRepository.FindAsync(f => f.ResourceName == username,
                i => i.Include(x => x.ResourceRole).ThenInclude(rr => rr.Role)));
        }

        /// <summary>
        /// Gets the resource data.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ResourceModel>> GetResourceData(int pageIndex = 1, int pageSize = 25)
        {
            var dbResponse = await this.ResourceRepository.GetPagedListAsync(null, null, f => f.Include(q => q.ResourceRole), pageIndex, pageSize);
            return Mapper.Map<IEnumerable<ResourceModel>>(dbResponse.Items);
        }

        #endregion
    }
}