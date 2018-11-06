using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchWCF
{
    public class OrderDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Pizza> Pizzas { get; set; }
        public List<Drink> Drinks { get; set; }
    }
}
