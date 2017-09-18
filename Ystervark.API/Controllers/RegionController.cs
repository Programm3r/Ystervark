using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;
using Ystervark.API.Attributes;
using Ystervark.API.Controllers.Base;
using Ystervark.Database.Models;
using Ystervark.Manager.Interface;
using Ystervark.Models.DTO;
using Ystervark.Models.Helper;

namespace Ystervark.API.Controllers
{
    /// <summary>
    /// Region Controller Class
    /// </summary>
    /// <seealso cref="BaseController{IRegionManager}" />
    [CustomAuthorize]
    [Route("api/[controller]")]
    public class RegionController : BaseController<IRegionManager>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegionController" /> class.
        /// </summary>
        /// <param name="manager">The manager.</param>
        /// <param name="mapper">The mapper.</param>
        public RegionController(IRegionManager manager, IMapper mapper) : base(manager, mapper)
        {
        }

        /// <summary>
        /// Posts the specified region.
        /// </summary>
        /// <param name="region">The region.</param>
        /// <returns></returns>
        [HttpPost]
        [SwaggerResponse(200, typeof(Response<RegionModel>))]
        public async Task<IActionResult> Post([FromBody] RegionModel region)
        {
            return await base.ConstructResponseAsync<RegionModel, Region>(() => this.Manager.Insert(region));
        }

        /// <summary>
        /// Puts the specified region.
        /// </summary>
        /// <param name="region">The region.</param>
        /// <returns></returns>
        [HttpPut]
        [SwaggerResponse(200, typeof(Response<RegionModel>))]
        public async Task<IActionResult> Put([FromBody] RegionModel region)
        {
            return await base.ConstructResponseAsync<RegionModel, Region>(() => this.Manager.Update(region));
        }
    }
}