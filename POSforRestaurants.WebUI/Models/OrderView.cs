using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POSforRestaurants.WebUI.Models
{
    public class OrderView
    {
        public int OrderId { get; set; }

        public double TipsAmount { get; set; }
        public double TotalPrice { get; set; }
        public OrderStateView OrderState { get; set; }

        public int SeatId { get; set; }
        //public Seat Seat { get; set; }

        public DateTime OpenedDate { get; set; }
        public DateTime ClosedDate { get; set; }

        public ICollection<ItemView> Items { get; set; }
        public OrderView()
        {
            Items = new List<ItemView>();
        }

        
    }
    public enum OrderStateView
    {
        Active,
        Voided,
        Paid
    }
}