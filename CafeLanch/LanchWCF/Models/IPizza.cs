using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LanchWCF
{
    [ServiceContract]
    public interface IPizza
    {
        [OperationContract]
        List<PizzaDTO>GetPizzas();

    }

}
