using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IStateMaterialService 
    {
        Task<StateMaterial> Create(StateMaterial StateMaterial);
        Task<StateMaterial> FindById(Guid Id);
        Task<StateMaterial> Delete(Guid Id);
        Task<StateMaterial> Update(StateMaterial StateMaterial);
        Task<IReadOnlyList<StateMaterial>> GetAll();
    }
}
