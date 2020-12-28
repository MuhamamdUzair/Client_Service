using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace KitchenWebHost
{
    public class Program 
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(KitchenWebService.KitchenService));
            host.Open();
            Console.WriteLine("Kitchen Host  Has started...");
            Console.ReadLine();
          //  OrderServiceClient abc = new OrderServiceClient();
        //    InstanceContext instanceContext = new InstanceContext(abc);
         // KitchenWebService.KitchenService kitchen = new KitchenWebService.KitchenService(instanceContext);
           //  abc.runCallback();
           // kitchen.SendToStationBurger(abc.Value);
            Console.ReadLine();
            host.Close();
          
        }
    }
}
