using LanchWCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LanchWCF.Interfaces
{
    [ServiceContract]
    public interface IDessert
    {
        [OperationContract]
        List<DessertDTO> GetDessert();
    }
}
