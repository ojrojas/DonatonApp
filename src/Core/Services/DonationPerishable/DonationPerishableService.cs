using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications;

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
           if(await this.IsListCLinton(DonationPerishable)) return null;
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

         private async Task<bool> IsListCLinton(DonationPerishable donationPerishable)
        {
            var specification = new DonationPerishableSpecification(
               donationPerishable.TypeIdentificationId, donationPerishable.Identification);
            var result = await this.asyncRepository.FirstOrDefaultAsync(specification);
            if (result != null) return true;
            return false;
        }
    }
}