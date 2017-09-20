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
        /// Gets all the resource data.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<ResourceModel>> GetAll();

        /// <summary>
        /// Gets the resource by identifier.
        /// </summary>
        /// <param name="resourceId">The resource identifier.</param>
        /// <returns></returns>
        Task<ResourceModel> GetById(int resourceId);

        /// <summary>
        /// Gets the resource by username.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns></returns>
        Task<ResourceModel> GetByUsername(string username);

        /// <summary>
        /// Gets the resource data by page index and size.
        /// </summary>
        /// <param name="pageIndex">Index of the page.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns></returns>
        Task<IEnumerable<ResourceModel>> GetByPage(int pageIndex = 1, int pageSize = 25);
    }
}