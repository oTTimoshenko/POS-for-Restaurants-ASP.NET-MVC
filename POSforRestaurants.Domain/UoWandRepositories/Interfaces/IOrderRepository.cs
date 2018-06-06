using POSforRestaurants.Domain.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSforRestaurants.Domain.UoWandRepositories.Interfaces
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<Order> GetByIdAsync(int id);
        void DeclineOrder(Order order);
        void PayForOrder(Order order);
    }
}
