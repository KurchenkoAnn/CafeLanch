using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LanchWCF
{
    [ServiceContract]
    public interface IOrder
    {
        [OperationContract]
        List<OrderDTO> GetOrders();
        [OperationContract]
        void SendOnEmail(string Subject, string Messege,OrderDTO order);
    }
}
