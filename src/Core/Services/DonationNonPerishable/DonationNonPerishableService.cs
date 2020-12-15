using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications;

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
            if(await this.IsListCLinton(DonationNonPerishable)) return null;
            return await this.asyncRepository.CreateAsync(DonationNonPerishable);
        }

        public async Task<DonationNonPerishable> Delete(Guid Id)
        {
            var DonationNonPerishable = await this.asyncRepository.GetByIdAsync(Id);
            return await this.asyncRepository.DeleteAsync(DonationNonPerishable, DonationNonPerishable.Id);
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

        private async Task<bool> IsListCLinton(DonationNonPerishable donationNonPerishable)
        {
            var specification = new DonationNonPerishableSpecification(
               donationNonPerishable.TypeIdentificationId, donationNonPerishable.Identification);
            var result = await this.asyncRepository.FirstOrDefaultAsync(specification);
            if (result != null) return true;
            return false;
        }
    }
}