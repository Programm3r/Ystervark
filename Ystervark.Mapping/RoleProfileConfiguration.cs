using AutoMapper;
using Ystervark.Database.Models;
using Ystervark.Models.DTO;

namespace Ystervark.Mapping
{
    /// <summary>
    /// Role Profile Configuration Mapping Class
    /// </summary>
    /// <seealso cref="AutoMapper.Profile" />
    public class RoleProfileConfiguration : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleProfileConfiguration"/> class.
        /// </summary>
        public RoleProfileConfiguration()
        {
            CreateMap<RoleModel, Role>().ReverseMap();
        }
    }
}