using POSforRestaurants.Domain.Data.Entities;
using POSforRestaurants.Domain.UoWandRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSforRestaurants.Domain.UoWandRepositories.Realization
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext context)
            : base(context)
        { }

        public Category GetById(int id)
        {
            return _dbset.Include(x => x.Items).Where(x => x.CategoryId == id).FirstOrDefault();
        }
    }
}
