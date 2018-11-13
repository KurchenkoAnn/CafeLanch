using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeLanch.models
{
   public class Order
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public List<Pizza> Pizzas { get; set; }
        public List<Sushi> Sushis { get; set; }
        public List<Drink> Drinks { get; set; }
    }
}
