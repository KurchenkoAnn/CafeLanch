using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLanchDAL.models
{
   public class Drink
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Path { get; set; }
        public List<Order> Orders { get; set; }
        public Category Category { get; set; }

    }
}
