using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;

namespace Core.Services  
{
    public class TypeIdentificationService : ITypeIdentificationService
    {
        private readonly IAsyncRepository<TypeIdentification> asyncRepository;

        public TypeIdentificationService(IAsyncRepository<TypeIdentification> asyncRepository)
        {
            this.asyncRepository = asyncRepository;
        }

        public async Task<TypeIdentification> Create(TypeIdentification typeIdentification)
        {
           return await this.asyncRepository.CreateAsync(typeIdentification);
        }

        public async Task<TypeIdentification> Delete(Guid Id)
        {
            var typeIdentification = await this.asyncRepository.GetByIdAsync(Id);
           return await this.asyncRepository.DeleteAsync(typeIdentification,typeIdentification.Id);
        }

        public async Task<TypeIdentification> FindById(Guid Id)
        {
           return await this.asyncRepository.GetByIdAsync(Id);
        }

        public async Task<IReadOnlyList<TypeIdentification>> GetAll()
        {
           return await this.asyncRepository.GetAllAsync();
        }

        public async Task<TypeIdentification> Update(TypeIdentification typeIdentification)
        {
           return await this.asyncRepository.UpdateAsync(typeIdentification);
        }
    }
}