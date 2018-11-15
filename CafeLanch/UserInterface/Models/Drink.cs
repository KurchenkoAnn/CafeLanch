using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApp11.Models
{
   public  class Drink
    {
        public int ID { get; set; }
       
        public string Name { get; set; }
        public List<Order> Orders { get; set; }
        public Category Category { get; set; }

    }
}
