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
    public class TypeDonationsController : ControllerBase
    {
        /// <summary>
        /// Async Identity Repository
        /// </summary>
        private readonly ITypeDonationService _typeDonationService;

        /// <summary>
        /// Constructor ITypeDonationService Controller
        /// </summary>
        /// <param name="ITypeDonationService"></param>
        public TypeDonationsController(ITypeDonationService typeDonationService)
        {
            _typeDonationService = typeDonationService;
        }

        [HttpGet]
        [ResponseCache(Duration= 60)]
        /// <summary>
        /// Get ITypeDonationService 
        /// </summary>
        /// <returns>List TypeDonations</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(IReadOnlyList<TypeDonation>), StatusCodes.Status200OK)]
        public async Task<IReadOnlyList<TypeDonation>> GetAllAsync()
        {
            return await this._typeDonationService.GetAll();
        }

        [HttpPost]
        /// <summary>
        /// Post TypeDonation App
        /// </summary>
        /// <returns>TypeDonation created</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(TypeDonation), StatusCodes.Status200OK)]
        public async Task<TypeDonation> CreateTypeDonation([FromBody] TypeDonation TypeDonation)
        {
            return await this._typeDonationService.Create(TypeDonation);
        }
       
        [HttpPut]
        /// <summary>
        /// Put TypeDonation 
        /// </summary>
        /// <returns>TypeDonation created</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(TypeDonation), StatusCodes.Status200OK)]
        public async Task<TypeDonation> UpdateTypeDonation(TypeDonation TypeDonation)
        {
            return await this._typeDonationService.Update(TypeDonation);
        }

        [HttpDelete("{Id}")]
        /// <summary>
        /// Delete TypeDonation 
        /// </summary>
        /// <returns>TypeDonation created</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(TypeDonation), StatusCodes.Status200OK)]
        public async Task<TypeDonation> DeleteTypeDonation(Guid Id)
        {
            return await this._typeDonationService.Delete(Id);
        }

        [HttpGet]
        [Route("FindTypeDonation/{Id}")]
        /// <summary>
        /// Delete TypeDonation App
        /// </summary>
        /// <returns>TypeDonation created</returns>
        [Produces("application/json")]
        [ProducesResponseType(typeof(TypeDonation), StatusCodes.Status200OK)]
        public async Task<TypeDonation> FindTypeDonation(Guid Id)
        {
            return await this._typeDonationService.FindById(Id);
        }
    }
}