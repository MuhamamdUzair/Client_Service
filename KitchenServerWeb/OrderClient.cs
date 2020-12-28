//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.ServiceModel;


//namespace KitchenWebService
//{
//    [CallbackBehavior(UseSynchronizationContext = false)]
//    class OrderClient
//    {
//        InstanceContext instanceContext;
//        OrderService.Service1Client clients;
//        OrderService.Order order;
//        //KitchenService kitchenService;
//        public OrderClient()
//        {
//            instanceContext = new InstanceContext(this);
//            clients = new OrderService.Service1Client();
//            order = new OrderService.Order();

//        }
//        public OrderService.Order runCallback()
//        {
//            order = clients.OrderPlace();

                
//            return order;
//            //   kitchenService.SendToStationBurger(order.OrderID, order.OrderName);
//            // Console.WriteLine(Total.ToString() + " Order Pizza completed");
//        }
//        /*
//        KitchenService kitchenService = new KitchenService();
//        public void OrderBurger(int Total)
//        {
//            Console.WriteLine(Total.ToString() + " Order Burger completed");
//          //  kitchenService.SendToStationBurger(Total);
   
//        }
//        public void OrderPizza(int Total)
//        {
//            Console.WriteLine(Total.ToString() + " Order Pizza completed");
//           // kitchenService.SendToStationPizaa(Total);

//        }*/
//    }
//}
