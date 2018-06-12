using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using POSforRestaurants.Domain.Data.Entities;
using POSforRestaurants.Logic.DTO;

namespace POSforRestaurants.Logic.Infrastructure
{
    public class MappingLogicConfig:Profile
    {
        public MappingLogicConfig()
        {
            CreateMap<CategoryDTO, Category>().ReverseMap().MaxDepth(2);
            CreateMap<ItemDTO, Item>().ReverseMap().MaxDepth(2);
            CreateMap<SeatDTO, Seat>().ReverseMap().MaxDepth(2);
            CreateMap<OrderDTO, Order>().ReverseMap().MaxDepth(2);
            CreateMap<OrderStateDTO, OrderState>().ReverseMap();
            CreateMap<SeatStatusDTO, SeatStatus>().ReverseMap();
        }
    }
}
