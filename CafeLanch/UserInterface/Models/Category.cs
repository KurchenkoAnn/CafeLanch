using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApp11.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Drink> Drinks { get; set; }
    }

}

