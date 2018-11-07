using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LanchWCF
{
    [DataContract]
    public class PizzaDTO 
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public string Path { get; set; }
        [DataMember]
        public List<IngredientDTO> Ingredients { get; set; }
        [DataMember]
        public List<OrderDTO> Orders { get; set; }
    }
}
