using POSforRestaurants.Logic.DTO;
using POSforRestaurants.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace POSforRestaurants.WebUI.Infrastructure
{
    public class MappingUIConfig:Profile
    {
        public MappingUIConfig()
        {
            CreateMap<CategoryDTO, CategoryView>().ReverseMap().MaxDepth(2);
            CreateMap<ItemDTO, ItemView>().ReverseMap().MaxDepth(2);
            CreateMap<SeatDTO, SeatView>().ReverseMap().MaxDepth(2);
            CreateMap<OrderDTO, OrderView>().ReverseMap().MaxDepth(2);
            CreateMap<OrderStateDTO, OrderStateView>().ReverseMap();
            CreateMap<SeatStatusDTO, SeatStatusView>().ReverseMap();
        }
    }
}