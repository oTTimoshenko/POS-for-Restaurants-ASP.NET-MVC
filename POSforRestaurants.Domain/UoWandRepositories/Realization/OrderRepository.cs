using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSforRestaurants.Domain.Data.Entities;
using POSforRestaurants.Domain.UoWandRepositories.Interfaces;
using System.Data.Entity;

namespace POSforRestaurants.Domain.UoWandRepositories.Realization
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(DbContext context)
           : base(context)
        { }

        public Order GetById(int id)
        {
            return _dbset.Where(x => x.OrderId == id).FirstOrDefault();
        }
    }
}
