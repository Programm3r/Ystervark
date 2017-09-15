using System.Collections.Generic;
using System.Threading.Tasks;
using Ystervark.Database.Models;
using Ystervark.Manager.Base;
using Ystervark.Manager.Interface;
using Ystervark.Models.DTO;
using Ystervark.Repository.Interface;

namespace Ystervark.Manager.Implementation
{
    public class ClientManager : BaseManager, IClientManager
    {
        #region ClientManager - Repository Properties

        /// <summary>
        /// Gets the client repository.
        /// </summary>
        /// <value>
        /// The client repository.
        /// </value>
        public IRepository<Client> ClientRepository => base.UnitOfWork.GetRepository<Client>();

        #endregion

        #region Implementation of IClientManager

        public async Task<IEnumerable<ClientModel>> GetClientData()
        {
            var dbResponse = await ClientRepository.GetPagedListAsync(null, null, null, 1, 25);
            return Mapper.Map<IEnumerable<ClientModel>>(dbResponse.Items);
        }

        #endregion
    }
}