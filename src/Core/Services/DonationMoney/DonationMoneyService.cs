using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Core.Specifications;

namespace Core.Services  
{
    public class DonationMoneyService : IDonationMoneyService
    {
        private readonly IAsyncRepository<DonationMoney> asyncRepository;

        public DonationMoneyService(IAsyncRepository<DonationMoney> asyncRepository)
        {
            this.asyncRepository = asyncRepository;
        }

        public async Task<DonationMoney> Create(DonationMoney DonationMoney)
        {
            if(await this.IsListCLinton(DonationMoney)) return null;
            return await this.asyncRepository.CreateAsync(DonationMoney);
        }

        public async Task<DonationMoney> Delete(Guid Id)
        {
            var DonationMoney = await this.asyncRepository.GetByIdAsync(Id);
           return await this.asyncRepository.DeleteAsync(DonationMoney,DonationMoney.Id);
        }

        public async Task<DonationMoney> FindById(Guid Id)
        {
           return await this.asyncRepository.GetByIdAsync(Id);
        }

        public async Task<IReadOnlyList<DonationMoney>> GetAll()
        {
           return await this.asyncRepository.GetAllAsync();
        }

        public async Task<DonationMoney> Update(DonationMoney DonationMoney)
        {
           return await this.asyncRepository.UpdateAsync(DonationMoney);
        }

        private async Task<bool> IsListCLinton(DonationMoney donationMoney)
        {
            var specification = new DonationMoneySpecification(donationMoney.TypeIdentificationId, donationMoney.Identification);
            var result =  await this.asyncRepository.FirstOrDefaultAsync(specification);
            if(result != null) return true;
            return false;
        }
    }
}