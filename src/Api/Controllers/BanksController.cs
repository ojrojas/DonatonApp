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
    // [Authorize]
    [AllowAnonymous]
    [Route("api/[controller]")]
    public class BanksController : ControllerBase
    {
        /// <summary>
        /// Async Identity Repository
        /// </summary>
        private readonly IBankService _bankService;

        /// <summary>
        /// Constructor IBankService Controller
        /// </summary>
        /// <param name="IBankService"></param>
        public BanksController(IBankService bankService)
        {
            _bankService = bankService;
        }

        [HttpGet]
        [ResponseCache(Duration= 60)]
        /// <summary>
        /// Get Banks 
        /// </summary>
        /// <returns>List Banks</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(IReadOnlyList<Bank>), StatusCodes.Status200OK)]
        public async Task<IReadOnlyList<Bank>> GetAllAsync()
        {
            return await this._bankService.GetAll();
        }

        [HttpPost]
        /// <summary>
        /// Post Bank App
        /// </summary>
        /// <returns>Bank created</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(Bank), StatusCodes.Status200OK)]
        public async Task<Bank> CreateBank([FromBody] Bank Bank)
        {
            return await this._bankService.Create(Bank);
        }
       
        [HttpPut]
        /// <summary>
        /// Put Bank 
        /// </summary>
        /// <returns>Bank created</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(Bank), StatusCodes.Status200OK)]
        public async Task<Bank> UpdateBank(Bank Bank)
        {
            return await this._bankService.Update(Bank);
        }

        [HttpDelete("{Id}")]
        /// <summary>
        /// Delete Bank 
        /// </summary>
        /// <returns>Bank created</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(Bank), StatusCodes.Status200OK)]
        public async Task<Bank> DeleteBank(Guid Id)
        {
            return await this._bankService.Delete(Id);
        }

        [HttpGet]
        [Route("FindBank/{Id}")]
        /// <summary>
        /// Delete Bank App
        /// </summary>
        /// <returns>Bank created</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(Bank), StatusCodes.Status200OK)]
        public async Task<Bank> FindBank(Guid Id)
        {
            return await this._bankService.FindById(Id);
        }
    }
}