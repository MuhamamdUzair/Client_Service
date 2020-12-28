using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace OrderWebHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(orderWebService.Service1)))
            {
                host.Open();
                Console.WriteLine("Order Host Has started...");
                Console.ReadLine();
            }
        }
    }
}
