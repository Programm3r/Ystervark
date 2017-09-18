using AutoMapper;
using Ystervark.Database.Models;
using Ystervark.Models.DTO;

namespace Ystervark.Mapping
{
    /// <summary>
    /// Client Profile Configuration Mapping Class
    /// </summary>
    /// <seealso cref="AutoMapper.Profile" />
    public class ClientProfileConfiguration : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientProfileConfiguration"/> class.
        /// </summary>
        public ClientProfileConfiguration()
        {
            CreateMap<ClientModel, Client>().ReverseMap();
        }
    }
}