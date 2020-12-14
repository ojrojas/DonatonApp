using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IDonationMoneyService   
    {
        Task<DonationMoney> Create(DonationMoney DonationMoney);
        Task<DonationMoney> FindById(Guid Id);
        Task<DonationMoney> Delete(Guid Id);
        Task<DonationMoney> Update(DonationMoney DonationMoney);
        Task<IReadOnlyList<DonationMoney>> GetAll();
    }
}