using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace KitchenWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "KitchenService" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class KitchenService : IKitchenService, OrderService.IService1Callback
    {
       
        
        Queue<Order> orders = new Queue<Order>();
        public void SendToStationBurger()

        {
            InstanceContext instance = new InstanceContext(this);
            OrderService.Service1Client clients = new OrderService.Service1Client(instance);
            clients.OrderPlace();
          //  order.OrderID = orderX.OrderID;
            //order.OrderName = orderX.OrderName;
            // Console.WriteLine("Order Burger Process ID " + i.ToString());
            Thread.Sleep(1000);
            // Get the callback channel to send messages to the client
            while (orders.Count > 0) 
            {
                Callback.OrderBurger(orders.Dequeue());
            }
            //return i.ToString();
        }

        public void OrderDone(OrderService.Order Total)
        {
            Order order = new Order();
            order.OrderID = Total.OrderID;
            order.OrderName = Total.OrderName;
            Console.WriteLine(order.OrderName + "  Order Recieved by kitchen");
            orders.Enqueue(order);

        }

        IReportServiceCallback Callback
        {
            get
            {
                return OperationContext.Current.GetCallbackChannel<IReportServiceCallback>();
            }

        }
    }
}
