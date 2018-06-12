using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSforRestaurants.Logic.DTO
{
    public class OrderDTO
    {

        public int OrderId { get; set; }

        public double TipsAmount { get; set; }
        public double TotalPrice { get; set; }
        public OrderStateDTO OrderState { get; set; }

        public int SeatId { get; set; }
        //public Seat Seat { get; set; }

        public DateTime OpenedDate { get; set; }
        public DateTime ClosedDate { get; set; }

        public ICollection<ItemDTO> Items { get; set; }
        public OrderDTO()
        {
            Items = new List<ItemDTO>();
        }
    }

    public enum OrderStateDTO
    {
        Active,
        Voided,
        Paid
    }
}
