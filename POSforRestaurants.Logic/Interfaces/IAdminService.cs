using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSforRestaurants.Logic.DTO;

namespace POSforRestaurants.Logic.Interfaces
{
    public interface IAdminService
    {
        Task<bool> AddCategory(CategoryDTO categoryDTO);
        Task<bool> AddSeat(SeatDTO seatDTO);
        Task<bool> AddItem(ItemDTO itemDTO);

        Task<bool> UpdateCategory(CategoryDTO categoryDTO);
        Task<bool> UpdateSeat(SeatDTO seatDTO);
        Task<bool> UpdateItem(ItemDTO itemDTO);

        Task<bool> RemoveCategory(int id);
        Task<bool> RemoveSeat(int id);
        Task<bool> RemoveItem(int id);
        Task<bool> RemoveOrder(int id);
    }
}
