using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;

namespace Core.Services  
{
    public class ListClintonService : IListClintonService
    {
        private readonly IAsyncRepository<ListClinton> asyncRepository;

        public ListClintonService(IAsyncRepository<ListClinton> asyncRepository)
        {
            this.asyncRepository = asyncRepository;
        }

        public async Task<ListClinton> Create(ListClinton ListClinton)
        {
           return await this.asyncRepository.CreateAsync(ListClinton);
        }

        public async Task<ListClinton> Delete(Guid Id)
        {
            var ListClinton = await this.asyncRepository.GetByIdAsync(Id);
           return await this.asyncRepository.DeleteAsync(ListClinton,ListClinton.Id);
        }

        public async Task<ListClinton> FindById(Guid Id)
        {
           return await this.asyncRepository.GetByIdAsync(Id);
        }

        public async Task<IReadOnlyList<ListClinton>> GetAll()
        {
           return await this.asyncRepository.GetAllAsync();
        }

        public async Task<ListClinton> Update(ListClinton ListClinton)
        {
           return await this.asyncRepository.UpdateAsync(ListClinton);
        }
    }
}