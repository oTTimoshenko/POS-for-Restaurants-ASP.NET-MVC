using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSforRestaurants.Domain.Data.Entities
{
    public class Seat
    {
        [Key]
        public int SeatId { get; set; }

        public string Name { get; set; }

        public ICollection<Order> Orders { get; set; }

        public Seat()
        {
            Orders = new List<Order>();
        }
    }
}
