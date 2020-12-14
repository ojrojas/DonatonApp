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
    public class ListClintonsController : ControllerBase
    {
        /// <summary>
        /// Async Identity Repository
        /// </summary>
        private readonly IListClintonService _listClintonService;

        /// <summary>
        /// Constructor IListClintonService Controller
        /// </summary>
        /// <param name="IListClintonService"></param>
        public ListClintonsController(IListClintonService listClintonService)
        {
            _listClintonService = listClintonService;
        }

        [HttpGet]
        [ResponseCache(Duration= 60)]
        /// <summary>
        /// Get ListClintons 
        /// </summary>
        /// <returns>List ListClintons</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(IReadOnlyList<ListClinton>), StatusCodes.Status200OK)]
        public async Task<IReadOnlyList<ListClinton>> GetAllAsync()
        {
            return await this._listClintonService.GetAll();
        }

        [HttpPost]
        /// <summary>
        /// Post ListClinton App
        /// </summary>
        /// <returns>ListClinton created</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(ListClinton), StatusCodes.Status200OK)]
        public async Task<ListClinton> CreateListClinton([FromBody] ListClinton ListClinton)
        {
            return await this._listClintonService.Create(ListClinton);
        }
       
        [HttpPut]
        /// <summary>
        /// Put ListClinton 
        /// </summary>
        /// <returns>ListClinton created</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(ListClinton), StatusCodes.Status200OK)]
        public async Task<ListClinton> UpdateListClinton(ListClinton ListClinton)
        {
            return await this._listClintonService.Update(ListClinton);
        }

        [HttpDelete("{Id}")]
        /// <summary>
        /// Delete ListClinton 
        /// </summary>
        /// <returns>ListClinton created</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(ListClinton), StatusCodes.Status200OK)]
        public async Task<ListClinton> DeleteListClinton(Guid Id)
        {
            return await this._listClintonService.Delete(Id);
        }

        [HttpGet]
        [Route("FindListClinton/{Id}")]
        /// <summary>
        /// Delete ListClinton App
        /// </summary>
        /// <returns>ListClinton created</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(ListClinton), StatusCodes.Status200OK)]
        public async Task<ListClinton> FindListClinton(Guid Id)
        {
            return await this._listClintonService.FindById(Id);
        }
    }
}