using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POSforRestaurants.WebUI.Models
{
    public class ItemView
    {
        public int ItemId { get; set; }

        public string Name { get; set; }
        public double Price { get; set; }
        public string PicturePath { get; set; }
        //public int Count { get; set; }

        public int? CategoryId { get; set; }
        //public Category Category { get; set; }

        /*public ICollection<Order> Orders { get; set; }
        public Item()
        {
            Orders = new List<Order>();
        }*/
    }
}