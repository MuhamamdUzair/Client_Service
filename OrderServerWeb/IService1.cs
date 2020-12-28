using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace orderWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    // [ServiceContract(CallbackContract = typeof(IReportServiceCallback))]

    [ServiceContract(CallbackContract = typeof(IOrderServiceCallback))]
    public interface IService1
    {
        [OperationContract(IsOneWay = false)]
        void OrderPlace();
      
    }
    public interface IOrderServiceCallback
    {
        // Since we have not set IsOnway=true, the operation is Request/Reply operation
        [OperationContract(IsOneWay = true)]
        void OrderDone(Order Total);
    }
    public class Order
    {
        private int orderID;
        public int OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }
        private string orderName;
        public string OrderName
        {
            get { return orderName; }
            set { orderName = value; }
        }
    }
}

