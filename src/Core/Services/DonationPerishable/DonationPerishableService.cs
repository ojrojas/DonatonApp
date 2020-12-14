using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;

namespace Core.Services  
{
    public class DonationPerishableService : IDonationPerishableService
    {
        private readonly IAsyncRepository<DonationPerishable> asyncRepository;

        public DonationPerishableService(IAsyncRepository<DonationPerishable> asyncRepository)
        {
            this.asyncRepository = asyncRepository;
        }

        public async Task<DonationPerishable> Create(DonationPerishable DonationPerishable)
        {
           return await this.asyncRepository.CreateAsync(DonationPerishable);
        }

        public async Task<DonationPerishable> Delete(Guid Id)
        {
            var DonationPerishable = await this.asyncRepository.GetByIdAsync(Id);
           return await this.asyncRepository.DeleteAsync(DonationPerishable,DonationPerishable.Id);
        }

        public async Task<DonationPerishable> FindById(Guid Id)
        {
           return await this.asyncRepository.GetByIdAsync(Id);
        }

        public async Task<IReadOnlyList<DonationPerishable>> GetAll()
        {
           return await this.asyncRepository.GetAllAsync();
        }

        public async Task<DonationPerishable> Update(DonationPerishable DonationPerishable)
        {
           return await this.asyncRepository.UpdateAsync(DonationPerishable);
        }
    }
}