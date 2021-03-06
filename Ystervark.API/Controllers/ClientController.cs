﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;
using Ystervark.API.Attributes;
using Ystervark.API.Controllers.Base;
using Ystervark.Manager.Interface;
using Ystervark.Models.DTO;
using Ystervark.Models.Enums;

namespace Ystervark.API.Controllers
{
    /// <summary>
    /// Client Controller Class
    /// </summary>
    /// <seealso cref="BaseController{IResourceManager}" />
    [CustomAuthorize(Policy = AuthorizePolicy.AdministrativeManagers)]
    [Route("api/[controller]")]
    public class ClientController : BaseController<IClientManager>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceController" /> class.
        /// </summary>
        /// <param name="manager">The manager.</param>
        public ClientController(IClientManager manager) : base(manager)
        {
        }

        [HttpGet]
        [SwaggerResponse(200, typeof(IEnumerable<ClientModel>))]
        public async Task<IActionResult> Get()
        {
            return await base.ConstructResponseAsync(() => this.Manager.GetClientData());
        }

        [HttpGet]
        [Route("GetAsSummary")]
        [SwaggerResponse(200, typeof(IEnumerable<ClientSummaryModel>))]
        public async Task<IActionResult> GetAsSummary(bool? archived = null)
        {
            return await base.ConstructResponseAsync(() => this.Manager.GetAsSummary(archived));
        }
    }
}