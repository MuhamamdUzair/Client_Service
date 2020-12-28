using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;
namespace orderWebService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        Order savedOrder = new Order();
        public void OrderPlace()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                savedOrder.OrderID = i;
                savedOrder.OrderName = "Pizza" + i.ToString();
                Console.WriteLine(savedOrder.OrderName + " Order Has been Placed at " + DateTime.Now.ToString());
                Callback.OrderDone(savedOrder);
            }
        }

        IOrderServiceCallback Callback
        {
            get
            {
                return OperationContext.Current.GetCallbackChannel<IOrderServiceCallback>();
            }

        }

    }
}
    