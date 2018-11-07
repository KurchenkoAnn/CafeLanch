using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LanchWCF
{
    [ServiceContract]
    public interface IIngredient
    {
        [OperationContract]
        List<IngredientDTO> GetIngratients();
    }
}
