using LanchWCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LanchWCF
{
    [DataContract]
    public class OrderDTO
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public List<PizzaDTO> Pizzas { get; set; }
        [DataMember]
        public List<DrinkDTO> Drinks { get; set; }
    }
}
