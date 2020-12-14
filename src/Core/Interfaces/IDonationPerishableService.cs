using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IDonationPerishableService 
    {
        Task<DonationPerishable> Create(DonationPerishable DonationPerishable);
        Task<DonationPerishable> FindById(Guid Id);
        Task<DonationPerishable> Delete(Guid Id);
        Task<DonationPerishable> Update(DonationPerishable DonationPerishable);
        Task<IReadOnlyList<DonationPerishable>> GetAll();
    }
}