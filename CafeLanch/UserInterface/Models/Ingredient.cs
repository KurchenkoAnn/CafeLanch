using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApp11.Models
{
   public class Ingredient
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Pizza> Pizzas { get; set; }
    }
}
