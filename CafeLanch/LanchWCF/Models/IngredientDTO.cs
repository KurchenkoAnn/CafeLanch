﻿using LanchWCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LanchWCF
{
    [DataContract]
    public class IngredientDTO
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public List<PizzaDTO> Pizzas { get; set; }
        [DataMember]
        public List<SushiDTO> Sushis { get; set; }
        [DataMember]
        public List<DessertDTO> Desserts { get; set; }
    }
}
