using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSforRestaurants.Domain.UoWandRepositories.Interfaces
{
    public interface IGenericRepository<TDomainEntity>
        where TDomainEntity : class
    {
        Task<IEnumerable<TDomainEntity>> GetAllAsync();
        void Add(TDomainEntity entity);
        void Delete(TDomainEntity entity);
        void DeleteById(int Id);
        void Edit(TDomainEntity entity);
    }
}
