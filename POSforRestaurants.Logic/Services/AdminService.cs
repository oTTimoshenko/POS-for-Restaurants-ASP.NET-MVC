using POSforRestaurants.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSforRestaurants.Logic.DTO;
using POSforRestaurants.Domain.UoWandRepositories.Interfaces;
using AutoMapper;
using POSforRestaurants.Domain.Data.Entities;

namespace POSforRestaurants.Logic.Services
{
    public class AdminService : IAdminService
    {
        private readonly IUnitOfWork db;
        private readonly IMapper mapper;

        public AdminService(IUnitOfWork unitOfWork, IMapper _mapper)
        {
            db = unitOfWork;
            mapper = _mapper;
        }

        public async Task<bool> AddCategory(CategoryDTO categoryDTO)
        {
            try
            {
                var category = mapper.Map<Category>(categoryDTO);
                db.Categories.Add(category);
                await db.SaveAsync();
            }
            catch (Exception exc)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> AddSeat(SeatDTO seatDTO)
        {
            try
            {
                var seat = mapper.Map<Seat>(seatDTO);
                db.Seats.Add(seat);
                await db.SaveAsync();
            }
            catch (Exception exc)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> AddItem(ItemDTO itemDTO)
        {
            try
            {
                var item = mapper.Map<Item>(itemDTO);
                db.Items.Add(item);
                await db.SaveAsync();
            }
            catch (Exception exc)
            {
                return false;
            }
            return true;
        }


        public async Task<bool> RemoveCategory(int id)
        {
            try
            {
                db.Categories.DeleteById(id);
                await db.SaveAsync();
            }
            catch (Exception exc)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> RemoveItem(int id)
        {
            try
            {
                db.Items.DeleteById(id);
                await db.SaveAsync();
            }
            catch (Exception exc)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> RemoveOrder(int id)
        {
            try
            {
                db.Orders.DeleteById(id);
                await db.SaveAsync();
            }
            catch (Exception exc)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> RemoveSeat(int id)
        {
            try
            {
                db.Categories.DeleteById(id);
                await db.SaveAsync();
            }
            catch (Exception exc)
            {
                return false;
            }
            return true;
        }


        public async Task<bool> UpdateCategory(CategoryDTO categoryDTO)
        {
            try
            {
                var category = mapper.Map<Category>(categoryDTO);
                db.Categories.Edit(category);
                await db.SaveAsync();
            }
            catch (Exception exc)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> UpdateSeat(SeatDTO seatDTO)
        {
            try
            {
                var seat = mapper.Map<Seat>(seatDTO);
                db.Seats.Edit(seat);
                await db.SaveAsync();
            }
            catch (Exception exc)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> UpdateItem(ItemDTO itemDTO)
        {
            try
            {
                var item = mapper.Map<Item>(itemDTO);
                db.Items.Edit(item);
                await db.SaveAsync();
            }
            catch (Exception exc)
            {
                return false;
            }
            return true;
        }
    }
}
