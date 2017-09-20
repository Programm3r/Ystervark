using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;
using Ystervark.API.Attributes;
using Ystervark.API.Controllers.Base;
using Ystervark.Manager.Interface;
using Ystervark.Models.DTO;
using Ystervark.Models.Enums;
using Ystervark.Models.Helper;

namespace Ystervark.API.Controllers
{
    /// <summary>
    /// Resource Controller Class
    /// </summary>
    /// <seealso cref="BaseController{IResourceManager}" />
    [CustomAuthorize(Policy = AuthorizePolicy.AdministrativeManagers)]
    [Route("api/[controller]")]
    public class ResourceController : BaseController<IResourceManager>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceController"/> class.
        /// </summary>
        /// <param name="manager">The manager.</param>
        public ResourceController(IResourceManager manager) : base(manager)
        {
        }

        /// <summary>
        /// Gets the resource data for this instance.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [SwaggerResponse(200, typeof(Response<IEnumerable<ResourceModel>>))]        
        public async Task<IActionResult> Get()
        {
            return await base.ConstructResponseAsync(() => this.Manager.GetAll());
        }

        /// <summary>
        /// Gets the resource data for this instance.
        /// </summary>
        /// <param name="pageIndex">Index of the page.</param>
        /// <param name="pageSize">Size of the page.</param>
        /// <returns></returns>
        [HttpGet("Page/{pageIndex}/{pageSize}")]
        [SwaggerResponse(200, typeof(Response<IEnumerable<ResourceModel>>))]
        public async Task<IActionResult> Get(int pageIndex, int pageSize)
        {
            return await base.ConstructResponseAsync(() => this.Manager.GetByPage(pageIndex, pageSize));
        }
    }
}