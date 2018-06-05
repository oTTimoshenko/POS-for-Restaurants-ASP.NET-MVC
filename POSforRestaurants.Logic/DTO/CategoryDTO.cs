using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSforRestaurants.Logic.DTO
{
    public class CategoryDTO
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
