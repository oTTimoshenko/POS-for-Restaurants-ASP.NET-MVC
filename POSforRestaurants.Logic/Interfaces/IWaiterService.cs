using POSforRestaurants.Logic.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSforRestaurants.Logic.Interfaces
{
    public interface IWaiterService
    {
        //create order +
        //decline order
        //pay for order

        bool CreateOrder(OrderDTO orderDTO);
        bool DeclineOrder(OrderDTO orderDTO);
        bool PayForOrder(OrderDTO orderDTO);

        Task<bool> AddItemInOrder(OrderDTO orderDTO, int itemId);
        Task<bool> RemoveItemInOrder(OrderDTO orderDTO, int itemId);

        /*Task<OrderDTO> GetOrder(int id);
        Task<ItemDTO> GetItem(int id);
        Task<SeatDTO> GetSeat(int id);

        Task<IEnumerable<OrderDTO>> GetAllOrders();
        Task<IEnumerable<ItemDTO>> GetAllItems();
        Task<IEnumerable<SeatDTO>> GetAllSeats();*/
    }
}
