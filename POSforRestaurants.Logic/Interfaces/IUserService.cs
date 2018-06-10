using POSforRestaurants.Logic.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSforRestaurants.Logic.Interfaces
{
    public interface IUserService
    {
        Task<OrderDTO> GetOrder(int id);
        Task<ItemDTO> GetItem(int id);
        Task<SeatDTO> GetSeat(int id);

        Task<IEnumerable<CategoryDTO>> GetAllCategories();
        Task<IEnumerable<OrderDTO>> GetAllOrders();
        Task<IEnumerable<ItemDTO>> GetAllItems();
        Task<IEnumerable<SeatDTO>> GetAllSeats();
    }
}
