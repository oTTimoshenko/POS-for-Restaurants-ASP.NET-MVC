using POSforRestaurants.Domain.UoWandRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSforRestaurants.Domain.Data.Entities;
using POSforRestaurants.Domain.Data.Contexts;

namespace POSforRestaurants.Domain.UoWandRepositories.Realization
{
    public class UnitOfWork:IUnitOfWork
    {
        private DbContext _dbContext;

        private ICategoryRepository categoryRepository;
        private ISeatRepository seatRepository;
        private IItemRepository itemRepository;
        private IOrderRepository orderRepository;

        public UnitOfWork(string connectionString)
        {
            _dbContext = new PosContext(connectionString);
        }

        public ICategoryRepository Categories
        {
            get
            {
                if (categoryRepository == null)
                    categoryRepository = new CategoryRepository(_dbContext);
                return categoryRepository;
            }
        }

        public ISeatRepository Seats
        {
            get
            {
                if (seatRepository == null)
                    seatRepository = new SeatRepository(_dbContext);
                return seatRepository;
            }
        }

        public IItemRepository Items
        {
            get
            {
                if (itemRepository == null)
                    itemRepository = new ItemRepository(_dbContext);
                return itemRepository;
            }
        }

        public IOrderRepository Orders
        {
            get
            {
                if (orderRepository == null)
                    orderRepository = new OrderRepository(_dbContext);
                return orderRepository;
            }
        }

        public int Save()// Save changes
        {
            return _dbContext.SaveChanges();
        }

        // Disposes the current object
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool disposed = false;
        // Disposes all external resources.
        private void Dispose(bool disposing)
        {
            if (!this.disposed)
                if (disposing)
                {
                    if (_dbContext != null)
                    {
                        _dbContext.Dispose();
                    }
                }
            this.disposed = true;
        }
    }
}
