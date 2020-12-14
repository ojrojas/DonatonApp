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
    public class DonationNonPerishablesController : ControllerBase
    {
        /// <summary>
        /// Async Identity Repository
        /// </summary>
        private readonly IDonationNonPerishableService _donationNonPerishableService;

        /// <summary>
        /// Constructor IDonationNonPerishableService Controller
        /// </summary>
        /// <param name="IDonationNonPerishableService"></param>
        public DonationNonPerishablesController(IDonationNonPerishableService donationNonPerishableService)
        {
            _donationNonPerishableService = donationNonPerishableService;
        }

        [HttpGet]
        [ResponseCache(Duration= 60)]
        /// <summary>
        /// Get DonationNonPerishables 
        /// </summary>
        /// <returns>List DonationNonPerishables</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(IReadOnlyList<DonationNonPerishable>), StatusCodes.Status200OK)]
        public async Task<IReadOnlyList<DonationNonPerishable>> GetAllAsync()
        {
            return await this._donationNonPerishableService.GetAll();
        }

        [HttpPost]
        /// <summary>
        /// Post DonationNonPerishable App
        /// </summary>
        /// <returns>DonationNonPerishable created</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(DonationNonPerishable), StatusCodes.Status200OK)]
        public async Task<DonationNonPerishable> CreateDonationNonPerishable([FromBody] DonationNonPerishable DonationNonPerishable)
        {
            return await this._donationNonPerishableService.Create(DonationNonPerishable);
        }
       
        [HttpPut]
        /// <summary>
        /// Put DonationNonPerishable 
        /// </summary>
        /// <returns>DonationNonPerishable created</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(DonationNonPerishable), StatusCodes.Status200OK)]
        public async Task<DonationNonPerishable> UpdateDonationNonPerishable(DonationNonPerishable DonationNonPerishable)
        {
            return await this._donationNonPerishableService.Update(DonationNonPerishable);
        }

        [HttpDelete("{Id}")]
        /// <summary>
        /// Delete DonationNonPerishable 
        /// </summary>
        /// <returns>DonationNonPerishable created</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(DonationNonPerishable), StatusCodes.Status200OK)]
        public async Task<DonationNonPerishable> DeleteDonationNonPerishable(Guid Id)
        {
            return await this._donationNonPerishableService.Delete(Id);
        }

        [HttpGet]
        [Route("FindDonationNonPerishable/{Id}")]
        /// <summary>
        /// Delete DonationNonPerishable App
        /// </summary>
        /// <returns>DonationNonPerishable created</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(DonationNonPerishable), StatusCodes.Status200OK)]
        public async Task<DonationNonPerishable> FindDonationNonPerishable(Guid Id)
        {
            return await this._donationNonPerishableService.FindById(Id);
        }
    }
}