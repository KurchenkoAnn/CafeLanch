using cafeLanch.models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLanch.DAL.models
{
    public class Dessert
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<Order> Orders { get; set; }
    }
}
