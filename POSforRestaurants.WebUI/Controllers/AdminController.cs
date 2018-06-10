using AutoMapper;
using POSforRestaurants.Logic.DTO;
using POSforRestaurants.Logic.Interfaces;
using POSforRestaurants.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace POSforRestaurants.WebUI.Controllers
{
    public class AdminController : Controller
    {
        IAdminService admin;
        IUserService user;
        IMapper mapper;

        public AdminController(IAdminService admin, IUserService user, IMapper mapper)
        {
            this.admin = admin;
            this.user = user;
            this.mapper = mapper;
        }

        // GET: Admin
        [HttpGet]
        public async Task<ActionResult> Categories()
        {
            var categoriesDTO = await user.GetAllSeats();
            var categoriesView = mapper.Map<IEnumerable<CategoryView>>(categoriesDTO);

            return View(categoriesView);
        }

        [HttpGet]
        public async Task<ActionResult> Seats()
        {
            var seatsDTO = await user.GetAllSeats();
            var seatsView = mapper.Map<IEnumerable<SeatView>>(seatsDTO);

            return View(seatsView);
        }

        [HttpGet]
        public async Task<ActionResult> Items()
        {
            var itemsDTO = await user.GetAllItems();
            var itemsView = mapper.Map<IEnumerable<ItemView>>(itemsDTO);

            return View(itemsView);
        }

        [HttpGet]
        public async Task<ActionResult> Orders()
        {
            var ordersDTO = await user.GetAllOrders();
            var ordersView = mapper.Map<IEnumerable<OrderView>>(ordersDTO);

            return View(ordersView);
        }

        /*Task<bool> AddCategory(CategoryDTO categoryDTO);
        Task<bool> AddSeat(SeatDTO seatDTO);
        Task<bool> AddItem(ItemDTO itemDTO);*/

        [HttpPost]
        public async Task AddCategory(CategoryView categoryView)
        {
            var categoryDTO = mapper.Map<CategoryDTO>(categoryView);
            await admin.AddCategory(categoryDTO);
        }

        [HttpPost]
        public async Task AddSeat(SeatView seatView)
        {
            var seatDTO = mapper.Map<SeatDTO>(seatView);
            await admin.AddSeat(seatDTO);
        }

        [HttpPost]
        public async Task AddItem(ItemView itemView)
        {
            var itemDTO = mapper.Map<ItemDTO>(itemView);
            await admin.AddItem(itemDTO);
        }


        /*Task<bool> UpdateCategory(CategoryDTO categoryDTO);
        Task<bool> UpdateSeat(SeatDTO seatDTO);
        Task<bool> UpdateItem(ItemDTO itemDTO);*/
        [HttpPut]
        public async Task UpdateCategory(CategoryView categoryView)
        {
            var categoryDTO = mapper.Map<CategoryDTO>(categoryView);
            await admin.UpdateCategory(categoryDTO);
        }

        [HttpPut]
        public async Task UpdateSeat(SeatView seatView)
        {
            var seatDTO = mapper.Map<SeatDTO>(seatView);
            await admin.UpdateSeat(seatDTO);
        }

        [HttpPut]
        public async Task UpdateItem(ItemView itemView)
        {
            var itemDTO = mapper.Map<ItemDTO>(itemView);
            await admin.UpdateItem(itemDTO);
        }

        /*Task<bool> RemoveCategory(int id);
        Task<bool> RemoveSeat(int id);
        Task<bool> RemoveItem(int id);
        Task<bool> RemoveOrder(int id);*/
        [HttpDelete]
        public async Task DeleteCategory(int id)
        {
            await admin.RemoveCategory(id);
        }

        [HttpDelete]
        public async Task DeleteSeat(int id)
        {
            await admin.RemoveSeat(id);
        }

        [HttpDelete]
        public async Task DeleteItem(int id)
        {
            await admin.RemoveItem(id);
        }

        [HttpDelete]
        public async Task DeleteOrder(int id)
        {
            await admin.RemoveOrder(id);
        }
    }
}
 
 
 