using AutoMapper;
using Ystervark.Database.Models;
using Ystervark.Models.DTO;

namespace Ystervark.Mapping
{
    public class ClientProfileConfiguration : Profile
    {
        public ClientProfileConfiguration()
        {
            CreateMap<ClientModel, Client>().ReverseMap();
        }
    }
}