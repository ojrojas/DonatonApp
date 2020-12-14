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
    public class DonationMoneysController : ControllerBase
    {
        /// <summary>
        /// Async Identity Repository
        /// </summary>
        private readonly IDonationMoneyService _donationMoneyService;

        /// <summary>
        /// Constructor IDonationMoneyService Controller
        /// </summary>
        /// <param name="IDonationMoneyService"></param>
        public DonationMoneysController(IDonationMoneyService donationMoneyService)
        {
            _donationMoneyService = donationMoneyService;
        }

        [HttpGet]
        [ResponseCache(Duration= 60)]
        /// <summary>
        /// Get DonationMoneys 
        /// </summary>
        /// <returns>List DonationMoneys</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(IReadOnlyList<DonationMoney>), StatusCodes.Status200OK)]
        public async Task<IReadOnlyList<DonationMoney>> GetAllAsync()
        {
            return await this._donationMoneyService.GetAll();
        }

        [HttpPost]
        /// <summary>
        /// Post DonationMoney App
        /// </summary>
        /// <returns>DonationMoney created</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(DonationMoney), StatusCodes.Status200OK)]
        public async Task<DonationMoney> CreateDonationMoney([FromBody] DonationMoney DonationMoney)
        {
            return await this._donationMoneyService.Create(DonationMoney);
        }
       
        [HttpPut]
        /// <summary>
        /// Put DonationMoney 
        /// </summary>
        /// <returns>DonationMoney created</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(DonationMoney), StatusCodes.Status200OK)]
        public async Task<DonationMoney> UpdateDonationMoney(DonationMoney DonationMoney)
        {
            return await this._donationMoneyService.Update(DonationMoney);
        }

        [HttpDelete("{Id}")]
        /// <summary>
        /// Delete DonationMoney 
        /// </summary>
        /// <returns>DonationMoney created</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(DonationMoney), StatusCodes.Status200OK)]
        public async Task<DonationMoney> DeleteDonationMoney(Guid Id)
        {
            return await this._donationMoneyService.Delete(Id);
        }

        [HttpGet]
        [Route("FindDonationMoney/{Id}")]
        /// <summary>
        /// Delete DonationMoney App
        /// </summary>
        /// <returns>DonationMoney created</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(DonationMoney), StatusCodes.Status200OK)]
        public async Task<DonationMoney> FindDonationMoney(Guid Id)
        {
            return await this._donationMoneyService.FindById(Id);
        }
    }
}