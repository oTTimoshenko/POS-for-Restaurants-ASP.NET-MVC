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
        //make order
        //decline order
        //update order - optional
        //pay for order


        //add item in order
        //remove item from order

        //show info about order
        //show info about item
        //show info about seat

        //get orders history
        //get all items
        //get all seats

        Task<OrderDTO> GetOrder(int id);
        Task<ItemDTO> GetItem(int id);
        Task<SeatDTO> GetSeat(int id);

        Task<IEnumerable<OrderDTO>> GetAllOrders();
        Task<IEnumerable<ItemDTO>> GetAllItems();
        Task<IEnumerable<SeatDTO>> GetAllSeats();
    }
}
