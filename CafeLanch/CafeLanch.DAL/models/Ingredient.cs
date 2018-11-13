using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeLanch.models
{
   public class Ingredient
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Sushi> Sushis { get; set; }

        public List<Pizza> Pizzas { get; set; }

    }
}
