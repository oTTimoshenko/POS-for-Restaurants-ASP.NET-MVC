using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POSforRestaurants.WebUI.Models
{
    public class CategoryView
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        /* public ICollection<Item> Items { get; set; }

         public Category()
         {
             Items = new List<Item>();
         }*/
    }
}