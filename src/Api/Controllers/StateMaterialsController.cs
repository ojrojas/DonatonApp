using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class StateMaterialsController : ControllerBase
    {
        /// <summary>
        /// Async Identity Repository
        /// </summary>
        private readonly IStateMaterialService _stateMaterialService;

        /// <summary>
        /// Constructor IStateMaterialService Controller
        /// </summary>
        /// <param name="IStateMaterialService"></param>
        public StateMaterialsController(IStateMaterialService stateMaterialService)
        {
            _stateMaterialService = stateMaterialService;
        }

        [HttpGet]
        [ResponseCache(Duration= 60)]
        /// <summary>
        /// Get StateMaterials 
        /// </summary>
        /// <returns>List StateMaterials</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(IReadOnlyList<StateMaterial>), StatusCodes.Status200OK)]
        public async Task<IReadOnlyList<StateMaterial>> GetAllAsync()
        {
            return await this._stateMaterialService.GetAll();
        }

        [HttpPost]
        /// <summary>
        /// Post StateMaterial App
        /// </summary>
        /// <returns>StateMaterial created</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(StateMaterial), StatusCodes.Status200OK)]
        public async Task<StateMaterial> CreateStateMaterial([FromBody] StateMaterial StateMaterial)
        {
            return await this._stateMaterialService.Create(StateMaterial);
        }
       
        [HttpPut]
        /// <summary>
        /// Put StateMaterial 
        /// </summary>
        /// <returns>StateMaterial created</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(StateMaterial), StatusCodes.Status200OK)]
        public async Task<StateMaterial> UpdateStateMaterial(StateMaterial StateMaterial)
        {
            return await this._stateMaterialService.Update(StateMaterial);
        }

        [HttpDelete("{Id}")]
        /// <summary>
        /// Delete StateMaterial 
        /// </summary>
        /// <returns>StateMaterial created</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(StateMaterial), StatusCodes.Status200OK)]
        public async Task<StateMaterial> DeleteStateMaterial(Guid Id)
        {
            return await this._stateMaterialService.Delete(Id);
        }

        [HttpGet]
        [Route("FindStateMaterial/{Id}")]
        /// <summary>
        /// Delete StateMaterial App
        /// </summary>
        /// <returns>StateMaterial created</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(StateMaterial), StatusCodes.Status200OK)]
        public async Task<StateMaterial> FindStateMaterial(Guid Id)
        {
            return await this._stateMaterialService.FindById(Id);
        }
    }
}