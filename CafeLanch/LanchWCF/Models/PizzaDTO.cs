using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LanchWCF
{

    public class PizzaDTO 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Path { get; set; }
        public List<IngredientDTO> Ingredients { get; set; }
        public List<OrderDTO> Orders { get; set; }
    }
}
