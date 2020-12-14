using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IDonationNonPerishableService 
    {
        Task<DonationNonPerishable> Create(DonationNonPerishable DonationNonPerishable);
        Task<DonationNonPerishable> FindById(Guid Id);
        Task<DonationNonPerishable> Delete(Guid Id);
        Task<DonationNonPerishable> Update(DonationNonPerishable DonationNonPerishable);
        Task<IReadOnlyList<DonationNonPerishable>> GetAll();
    }
}