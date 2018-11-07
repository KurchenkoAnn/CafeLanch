﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeLanch.DAL.models
{
   public class Drink
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Order> Orders { get; set; }
        public Category Category { get; set; }

    }
}
