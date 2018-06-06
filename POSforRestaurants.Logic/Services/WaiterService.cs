using AutoMapper;
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

        public Task<IEnumerable<ItemDTO>> GetAllItems()
        {
            var items = db.Items.GetAllAsync();
            var itemsDTO = mapper.Map<Task<IEnumerable<ItemDTO>>>(items);
            return itemsDTO;
        }

        public Task<IEnumerable<OrderDTO>> GetAllOrders()
        {
            var orders = db.Orders.GetAllAsync();
            var ordersDTO = mapper.Map<Task<IEnumerable<OrderDTO>>>(orders);
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
        }
    }
}
