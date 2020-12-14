using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IBankService 
    {
        Task<Bank> Create(Bank Bank);
        Task<Bank> FindById(Guid Id);
        Task<Bank> Delete(Guid Id);
        Task<Bank> Update(Bank Bank);
        Task<IReadOnlyList<Bank>> GetAll();
    }
}