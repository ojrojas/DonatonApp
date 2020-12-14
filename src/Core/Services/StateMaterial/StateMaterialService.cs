using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;

namespace Core.Services  
{
    public class StateMaterialService : IStateMaterialService
    {
        private readonly IAsyncRepository<StateMaterial> asyncRepository;

        public StateMaterialService(IAsyncRepository<StateMaterial> asyncRepository)
        {
            this.asyncRepository = asyncRepository;
        }

        public async Task<StateMaterial> Create(StateMaterial StateMaterial)
        {
           return await this.asyncRepository.CreateAsync(StateMaterial);
        }

        public async Task<StateMaterial> Delete(Guid Id)
        {
            var StateMaterial = await this.asyncRepository.GetByIdAsync(Id);
           return await this.asyncRepository.DeleteAsync(StateMaterial,StateMaterial.Id);
        }

        public async Task<StateMaterial> FindById(Guid Id)
        {
           return await this.asyncRepository.GetByIdAsync(Id);
        }

        public async Task<IReadOnlyList<StateMaterial>> GetAll()
        {
           return await this.asyncRepository.GetAllAsync();
        }

        public async Task<StateMaterial> Update(StateMaterial StateMaterial)
        {
           return await this.asyncRepository.UpdateAsync(StateMaterial);
        }
    }
}