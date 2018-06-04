using POSforRestaurants.Domain.Data.Entities;
using POSforRestaurants.Domain.UoWandRepositories.Interfaces;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSforRestaurants.Domain.UoWandRepositories.Realization
{
   public  class ItemRepository:GenericRepository<Item>, IItemRepository
    {
        public ItemRepository(DbContext context)
             : base(context)
        { }

        public Item GetById(int id)
        {
            return _dbset.Where(x => x.ItemId == id).FirstOrDefault();
        }
    }
}
