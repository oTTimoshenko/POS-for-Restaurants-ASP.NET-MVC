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

        public async Task<Item> GetByIdAsync(int id)
        {
            return await _dbset.Where(x => x.ItemId == id).FirstOrDefaultAsync();
        }
    }
}
