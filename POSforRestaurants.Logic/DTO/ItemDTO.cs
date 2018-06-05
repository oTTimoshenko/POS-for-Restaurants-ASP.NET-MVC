using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSforRestaurants.Logic.DTO
{
    public  class ItemDTO
    {
        public int ItemId { get; set; }

        public string Name { get; set; }
        public double Price { get; set; }
        public string PicturePath { get; set; }

        public int? CategoryId { get; set; }
        //public Category Category { get; set; }

        /*public ICollection<Order> Orders { get; set; }
        public Item()
        {
            Orders = new List<Order>();
        }*/
    }
}
