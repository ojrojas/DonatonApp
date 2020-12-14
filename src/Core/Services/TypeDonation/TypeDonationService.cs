using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;

namespace Core.Services  
{
    public class TypeDonationService : ITypeDonationService
    {
        private readonly IAsyncRepository<TypeDonation> asyncRepository;

        public TypeDonationService(IAsyncRepository<TypeDonation> asyncRepository)
        {
            this.asyncRepository = asyncRepository;
        }

        public async Task<TypeDonation> Create(TypeDonation TypeDonation)
        {
           return await this.asyncRepository.CreateAsync(TypeDonation);
        }

        public async Task<TypeDonation> Delete(Guid Id)
        {
            var TypeDonation = await this.asyncRepository.GetByIdAsync(Id);
           return await this.asyncRepository.DeleteAsync(TypeDonation,TypeDonation.Id);
        }

        public async Task<TypeDonation> FindById(Guid Id)
        {
           return await this.asyncRepository.GetByIdAsync(Id);
        }

        public async Task<IReadOnlyList<TypeDonation>> GetAll()
        {
           return await this.asyncRepository.GetAllAsync();
        }

        public async Task<TypeDonation> Update(TypeDonation TypeDonation)
        {
           return await this.asyncRepository.UpdateAsync(TypeDonation);
        }
    }
}