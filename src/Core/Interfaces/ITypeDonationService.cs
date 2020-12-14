using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface ITypeDonationService 
    {
        Task<TypeDonation> Create(TypeDonation TypeDonation);
        Task<TypeDonation> FindById(Guid Id);
        Task<TypeDonation> Delete(Guid Id);
        Task<TypeDonation> Update(TypeDonation TypeDonation);
        Task<IReadOnlyList<TypeDonation>> GetAll();
    }
}
