using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POSforRestaurants.Domain.Data.Entities
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }

        public string Name { get; set; }
        public double Price { get; set; }
        public string PicturePath { get; set; }
        //public int Count { get; set; }

        [Column("CategoryId")]
        public int? CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<Order> Orders { get; set; }
        public Item()
        {
            Orders = new List<Order>();
        }
    }
}
