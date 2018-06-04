using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSforRestaurants.Domain.UoWandRepositories.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        ICategoryRepository Categories { get; }
        IItemRepository Items { get; }
        IOrderRepository Orders { get; }
        ISeatRepository Seats { get; }

        Task SaveAsync();
    }
}
