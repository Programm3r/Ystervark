using System.Collections.Generic;
using System.Threading.Tasks;
using Ystervark.Manager.Base;
using Ystervark.Models.DTO;

namespace Ystervark.Manager.Interface
{
    /// <summary>
    /// Client Manager Interface Declaration
    /// </summary>
    /// <seealso cref="Ystervark.Manager.Base.IBaseManager" />
    public interface IClientManager : IBaseManager
    {
        /// <summary>
        /// Gets the client data.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<ClientModel>> GetClientData();

        /// <summary>
        /// Gets the client data in a summarized collection.
        /// </summary>
        /// <param name="archived">if set to <c>true</c> archived clients will be included; otherwise <c>false</c>.</param>
        /// <returns></returns>
        Task<IEnumerable<ClientSummaryModel>> GetAsSummary(bool? archived = null);
    }
}