using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IListClintonService 
    {
        Task<ListClinton> Create(ListClinton ListClinton);
        Task<ListClinton> FindById(Guid Id);
        Task<ListClinton> Delete(Guid Id);
        Task<ListClinton> Update(ListClinton ListClinton);
        Task<IReadOnlyList<ListClinton>> GetAll();
    }
}
