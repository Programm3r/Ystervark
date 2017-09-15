using System.Collections.Generic;
using System.Threading.Tasks;
using Ystervark.Manager.Base;
using Ystervark.Models.DTO;

namespace Ystervark.Manager.Interface
{
    /// <summary>
    /// Resource Manager Interface
    /// </summary>
    public interface IResourceManager : IBaseManager
    {
        /// <summary>
        /// Authenticates the resource.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        Task<ResourceModel> AuthenticateResource(string username, string password);

        /// <summary>
        /// Gets all resource data.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<ResourceModel>> GetAllResourceData();

        /// <summary>
        /// Gets the resource by identifier.
        /// </summary>
        /// <param name="resourceId">The resource identifier.</param>
        /// <returns></returns>
        Task<ResourceModel> GetResourceById(int resourceId);

        /// <summary>
        /// Gets the resource by username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
        Task<ResourceModel> GetResourceByUsername(string username);

        /// <summary>
        /// Gets the resource data.
        /// </summary>
        /// <param name="pageIndex">Index of the page.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns></returns>
        Task<IEnumerable<ResourceModel>> GetResourceData(int pageIndex = 1, int pageSize = 25);
    }
}