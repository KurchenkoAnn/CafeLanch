using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLanch.DAL.models
{
   public class Ingredient
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Pizza> Pizzas { get; set; }

    }
}
