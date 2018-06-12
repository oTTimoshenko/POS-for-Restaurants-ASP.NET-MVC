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

        [HttpGet]
        public async Task<ActionResult> Categories()
        {
            var categoriesDTO = await user.GetAllCategories();
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

        [HttpGet]
        public ViewResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddCategory(CategoryView categoryView)
        {
            var categoryDTO = mapper.Map<CategoryDTO>(categoryView);
            await admin.AddCategory(categoryDTO);

            return RedirectToAction("Categories");
        }

        [HttpGet]
        public ViewResult AddSeat()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddSeat(SeatView seatView)
        {
            var seatDTO = mapper.Map<SeatDTO>(seatView);
            await admin.AddSeat(seatDTO);

            return RedirectToAction("Seats");
        }

        [HttpGet]
        public ViewResult AddItem()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddItem(ItemView itemView)
        {
            var itemDTO = mapper.Map<ItemDTO>(itemView);
            await admin.AddItem(itemDTO);

            return RedirectToAction("Items");
        }


        /*Task<bool> UpdateCategory(CategoryDTO categoryDTO);
        Task<bool> UpdateSeat(SeatDTO seatDTO);
        Task<bool> UpdateItem(ItemDTO itemDTO);*/

        [HttpGet]
        public async Task<ViewResult> UpdateCategory(int id)
        {
            var categoryDTO = await user.GetCategory(id);
            var categoryView = mapper.Map<CategoryView>(categoryDTO);
            return View(categoryView);
        }

        [HttpPost]
        public async Task<ActionResult> UpdateCategory(CategoryView categoryView)
        {
            var categoryDTO = mapper.Map<CategoryDTO>(categoryView);
            await admin.UpdateCategory(categoryDTO);

            return RedirectToAction("Categories");
        }

        [HttpGet]
        public async Task<ViewResult> UpdateSeat(int id)
        {
            var seatDTO = await user.GetSeat(id);
            var seatView = mapper.Map<SeatView>(seatDTO);
            return View(seatView);
        }

        [HttpPost]
        public async Task<ActionResult> UpdateSeat(SeatView seatView)
        {
            var seatDTO = mapper.Map<SeatDTO>(seatView);
            await admin.UpdateSeat(seatDTO);

            return RedirectToAction("Seats");
        }

        [HttpGet]
        public async Task<ViewResult> UpdateItem(int id)
        {
            var itemDTO = await user.GetItem(id);
            var itemView = mapper.Map<ItemView>(itemDTO);
            return View(itemView);
        }

        [HttpPost]
        public async Task<ActionResult> UpdateItem(ItemView itemView)
        {
            var itemDTO = mapper.Map<ItemDTO>(itemView);
            await admin.UpdateItem(itemDTO);

            return RedirectToAction("Items");
        }

        /*Task<bool> RemoveCategory(int id);
        Task<bool> RemoveSeat(int id);
        Task<bool> RemoveItem(int id);
        Task<bool> RemoveOrder(int id);*/
        

        [HttpGet]
        public async Task<ActionResult> DeleteCategory(int id)
        {
            await admin.RemoveCategory(id);

            return RedirectToAction("Categories");
        }

        [HttpGet]
        public async Task<ActionResult> DeleteSeat(int id)
        {
            await admin.RemoveSeat(id);

            return RedirectToAction("Seats");
        }

        [HttpGet]
        public async Task<ActionResult> DeleteItem(int id)
        {
            await admin.RemoveItem(id);

            return RedirectToAction("Items");
        }

        [HttpGet]
        public async Task<ActionResult> DeleteOrder(int id)
        {
            await admin.RemoveOrder(id);

            return RedirectToAction("Orders");
        }
    }
}
 
 
 