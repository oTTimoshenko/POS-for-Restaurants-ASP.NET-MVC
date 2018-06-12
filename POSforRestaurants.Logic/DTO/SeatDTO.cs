using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSforRestaurants.Logic.DTO
{
    public class SeatDTO
    {
        public int SeatId { get; set; }

        public string Name { get; set; }
        public SeatStatusDTO SeatStatus { get; set; }
        /* public ICollection<Order> Orders { get; set; }

           public Seat()
         {
            Orders = new List<Order>();
         }*/
    }

    public enum SeatStatusDTO
    {
        Available,
        Busy
    }
}
