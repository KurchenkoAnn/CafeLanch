using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLanch.DAL.models
{
    public class Pizza
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Path { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<Order> Orders { get; set; }

    }
}
