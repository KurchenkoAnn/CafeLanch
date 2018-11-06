using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchWCF
{
    public class IngredientDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<PizzaDTO> Pizzas { get; set; }
    }
}
