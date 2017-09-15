using AutoMapper;
using Ystervark.Database.Models;
using Ystervark.Models.DTO;

namespace Ystervark.Mapping
{
    /// <summary>
    /// Resource Role Profile Configuration Mapping Class
    /// </summary>
    /// <seealso cref="AutoMapper.Profile" />
    public class ResourceRoleProfileConfiguration : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceRoleProfileConfiguration"/> class.
        /// </summary>
        public ResourceRoleProfileConfiguration()
        {
            CreateMap<ResourceRoleModel, ResourceRole>().ReverseMap();
        }
    }
}