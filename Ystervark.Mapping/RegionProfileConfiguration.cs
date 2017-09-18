using AutoMapper;
using Ystervark.Database.Models;
using Ystervark.Models.DTO;

namespace Ystervark.Mapping
{
    /// <summary>
    /// Region Profile Configuration Mapping Class
    /// </summary>
    /// <seealso cref="AutoMapper.Profile" />
    public class RegionProfileConfiguration : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegionProfileConfiguration"/> class.
        /// </summary>
        public RegionProfileConfiguration()
        {
            CreateMap<RegionModel, Region>().ReverseMap();
        }
    }
}