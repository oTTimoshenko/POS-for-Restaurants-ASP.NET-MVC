using AutoMapper;
using POSforRestaurants.Domain.UoWandRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSforRestaurants.Domain.UoWandRepositories.Realization
{
    public abstract class GenericRepository<TDomainEntity> : IGenericRepository<TDomainEntity>
        where TDomainEntity : class
    {
        protected DbContext _entities;
        protected readonly IDbSet<TDomainEntity> _dbset;

        public GenericRepository(DbContext context)
        {
            _entities = context;
            _dbset = _entities.Set<TDomainEntity>();
        }

        public virtual IEnumerable<TDomainEntity> GetAll()
        {
            return _dbset.AsEnumerable<TDomainEntity>();
        }

        public virtual void Add(TDomainEntity entity)
        {
            _dbset.Add(entity);
        }

        public virtual void Delete(TDomainEntity entity)
        {
            _dbset.Remove(entity);
        }

        public virtual void DeleteById(int Id)
        {
            var _entity = _dbset.Find(Id);
            _dbset.Remove(_entity);
        }

        public virtual void Edit(TDomainEntity entity)
        {
            _entities.Entry(entity).State = EntityState.Modified;
        }
    }
}
