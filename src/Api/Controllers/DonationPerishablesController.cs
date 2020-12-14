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
    public class DonationPerishablesController : ControllerBase
    {
        /// <summary>
        /// Async Identity Repository
        /// </summary>
        private readonly IDonationPerishableService _donationPerishableService;

        /// <summary>
        /// Constructor IDonationPerishableService Controller
        /// </summary>
        /// <param name="IDonationPerishableService"></param>
        public DonationPerishablesController(IDonationPerishableService donationPerishableService)
        {
            _donationPerishableService = donationPerishableService;
        }

        [HttpGet]
        [ResponseCache(Duration= 60)]
        /// <summary>
        /// Get DonationPerishables 
        /// </summary>
        /// <returns>List DonationPerishables</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(IReadOnlyList<DonationPerishable>), StatusCodes.Status200OK)]
        public async Task<IReadOnlyList<DonationPerishable>> GetAllAsync()
        {
            return await this._donationPerishableService.GetAll();
        }

        [HttpPost]
        /// <summary>
        /// Post DonationPerishable App
        /// </summary>
        /// <returns>DonationPerishable created</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(DonationPerishable), StatusCodes.Status200OK)]
        public async Task<DonationPerishable> CreateDonationPerishable([FromBody] DonationPerishable DonationPerishable)
        {
            return await this._donationPerishableService.Create(DonationPerishable);
        }
       
        [HttpPut]
        /// <summary>
        /// Put DonationPerishable 
        /// </summary>
        /// <returns>DonationPerishable created</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(DonationPerishable), StatusCodes.Status200OK)]
        public async Task<DonationPerishable> UpdateDonationPerishable(DonationPerishable DonationPerishable)
        {
            return await this._donationPerishableService.Update(DonationPerishable);
        }

        [HttpDelete("{Id}")]
        /// <summary>
        /// Delete DonationPerishable 
        /// </summary>
        /// <returns>DonationPerishable created</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(DonationPerishable), StatusCodes.Status200OK)]
        public async Task<DonationPerishable> DeleteDonationPerishable(Guid Id)
        {
            return await this._donationPerishableService.Delete(Id);
        }

        [HttpGet]
        [Route("FindDonationPerishable/{Id}")]
        /// <summary>
        /// Delete DonationPerishable App
        /// </summary>
        /// <returns>DonationPerishable created</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(DonationPerishable), StatusCodes.Status200OK)]
        public async Task<DonationPerishable> FindDonationPerishable(Guid Id)
        {
            return await this._donationPerishableService.FindById(Id);
        }
    }
}