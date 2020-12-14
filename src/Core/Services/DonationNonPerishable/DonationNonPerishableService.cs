using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;

namespace Core.Services  
{
    public class DonationNonPerishableService : IDonationNonPerishableService
    {
        private readonly IAsyncRepository<DonationNonPerishable> asyncRepository;

        public DonationNonPerishableService(IAsyncRepository<DonationNonPerishable> asyncRepository)
        {
            this.asyncRepository = asyncRepository;
        }

        public async Task<DonationNonPerishable> Create(DonationNonPerishable DonationNonPerishable)
        {
           return await this.asyncRepository.CreateAsync(DonationNonPerishable);
        }

        public async Task<DonationNonPerishable> Delete(Guid Id)
        {
            var DonationNonPerishable = await this.asyncRepository.GetByIdAsync(Id);
           return await this.asyncRepository.DeleteAsync(DonationNonPerishable,DonationNonPerishable.Id);
        }

        public async Task<DonationNonPerishable> FindById(Guid Id)
        {
           return await this.asyncRepository.GetByIdAsync(Id);
        }

        public async Task<IReadOnlyList<DonationNonPerishable>> GetAll()
        {
           return await this.asyncRepository.GetAllAsync();
        }

        public async Task<DonationNonPerishable> Update(DonationNonPerishable DonationNonPerishable)
        {
           return await this.asyncRepository.UpdateAsync(DonationNonPerishable);
        }
    }
}