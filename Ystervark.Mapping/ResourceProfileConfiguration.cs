using AutoMapper;
using Ystervark.Database.Models;
using Ystervark.Models.DTO;

namespace Ystervark.Mapping
{
    public class ResourceProfileConfiguration : Profile
    {
        public ResourceProfileConfiguration()
        {
            CreateMap<ResourceModel, Resource>().ReverseMap();
        }
    }
}