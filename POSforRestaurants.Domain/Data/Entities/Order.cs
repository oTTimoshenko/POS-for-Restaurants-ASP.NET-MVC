using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSforRestaurants.Domain.Data.Entities
{
    public class Order
    {
        [Key]
        public int OredId { get; set; }

        public double TipsAmount { get; set; }
        public double TotalPrice { get; set; }
        public OrderState OrderState { get; set; }

        [Column("SeatId")]
        public int SeatId { get; set; }
        public Seat Seat { get; set; }

        public DateTime OpenedDate { get; set; }
        public DateTime ClosedDate { get; set; }

        public ICollection<Item> Items { get; set; }
        public Order()
        {
            Items = new List<Item>();
        }
    }

    public enum OrderState
    {
        Active,
        Voided,
        Paid
    }
}
