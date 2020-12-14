using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;

namespace Core.Services  
{
    public class BankService : IBankService
    {
        private readonly IAsyncRepository<Bank> asyncRepository;

        public BankService(IAsyncRepository<Bank> asyncRepository)
        {
            this.asyncRepository = asyncRepository;
        }

        public async Task<Bank> Create(Bank Bank)
        {
           return await this.asyncRepository.CreateAsync(Bank);
        }

        public async Task<Bank> Delete(Guid Id)
        {
            var Bank = await this.asyncRepository.GetByIdAsync(Id);
           return await this.asyncRepository.DeleteAsync(Bank,Bank.Id);
        }

        public async Task<Bank> FindById(Guid Id)
        {
           return await this.asyncRepository.GetByIdAsync(Id);
        }

        public async Task<IReadOnlyList<Bank>> GetAll()
        {
           return await this.asyncRepository.GetAllAsync();
        }

        public async Task<Bank> Update(Bank Bank)
        {
           return await this.asyncRepository.UpdateAsync(Bank);
        }
    }
}