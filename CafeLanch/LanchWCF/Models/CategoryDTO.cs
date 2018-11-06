﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchWCF.Models
{
   public class CategoryDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<DrinkDTO> Drinks { get; set; }
    }
}
