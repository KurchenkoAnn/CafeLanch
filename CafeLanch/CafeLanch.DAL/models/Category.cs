using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLanch.DAL.models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Drink> Drinks { get; set; }
    }
}
