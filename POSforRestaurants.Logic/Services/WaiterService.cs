using AutoMapper;
using POSforRestaurants.Domain.Data.Entities;
using POSforRestaurants.Domain.UoWandRepositories.Interfaces;
using POSforRestaurants.Logic.DTO;
using POSforRestaurants.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSforRestaurants.Logic.Services
{
   public class WaiterService:IWaiterService
    {
        private readonly IUnitOfWork db;
        private readonly IMapper mapper;

        public WaiterService(IUnitOfWork unitOfWork, IMapper _mapper)
        {
            db = unitOfWork;
            mapper = _mapper;
        }

        public bool CreateOrder(OrderDTO orderDTO)
        {
            try
            {
                var order = mapper.Map<Order>(orderDTO);
                db.Orders.Add(order);
            }
            catch(Exception ex)
            {
                return false;
            }

            return true;
        }
        public bool DeclineOrder(OrderDTO orderDTO)
        {
            try
            {
                var order = mapper.Map<Order>(orderDTO);
                db.Orders.DeclineOrder(order);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
        public bool PayForOrder(OrderDTO orderDTO)
        {
            try
            {
                var order = mapper.Map<Order>(orderDTO);
                db.Orders.PayForOrder(order);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public async Task<bool> AddItemInOrder(OrderDTO orderDTO, int itemId)
        {
            try
            {
                var item = await db.Items.GetByIdAsync(itemId);
                var itemDTO = mapper.Map<ItemDTO>(item);

                orderDTO.Items.Add(itemDTO);
                var order = mapper.Map<Order>(orderDTO);

                db.Orders.Edit(order);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
        public async Task<bool> RemoveItemInOrder(OrderDTO orderDTO, int itemId)
        {
            try
            {
                var item = await db.Items.GetByIdAsync(itemId);
                var itemDTO = mapper.Map<ItemDTO>(item);

                orderDTO.Items.Remove(itemDTO);
                var order = mapper.Map<Order>(orderDTO);

                db.Orders.Edit(order);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        /*public async Task<IEnumerable<ItemDTO>> GetAllItems()
        {
            var items = await db.Items.GetAllAsync();
            var itemsDTO = mapper.Map<IEnumerable<ItemDTO>>(items);
            return itemsDTO;
        }
        public async Task<IEnumerable<OrderDTO>> GetAllOrders()
        {
            var orders = await db.Orders.GetAllAsync();
            var ordersDTO = mapper.Map<IEnumerable<OrderDTO>>(orders);
            return ordersDTO;
        }
        public async Task<IEnumerable<SeatDTO>> GetAllSeats()
        {
            var seats = await db.Seats.GetAllAsync();
            var seatsDTO = await mapper.Map<Task<IEnumerable<SeatDTO>>>(seats);
            return seatsDTO;
        }

        public async Task<ItemDTO> GetItem(int id)
        {
            var item = await db.Items.GetByIdAsync(id);
            var itemDTO = mapper.Map<ItemDTO>(item);
            return itemDTO;
        }
        public async Task<OrderDTO> GetOrder(int id)
        {
            var order = await db.Orders.GetByIdAsync(id);
            var orderDTO = mapper.Map<OrderDTO>(order);
            return orderDTO;
        }
        public async Task<SeatDTO> GetSeat(int id)
        {
            var seat = await db.Seats.GetByIdAsync(id);
            var seatDTO = mapper.Map<SeatDTO>(seat);
            return seatDTO;
        }  */
    }
}
