using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ServiceModel;
using Station.KitchenService;

namespace Station
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
     [CallbackBehavior(UseSynchronizationContext = false)]
    public partial class MainWindow : Window, KitchenService.IKitchenServiceCallback
    {
        InstanceContext instanceContext;
        KitchenService.KitchenServiceClient clients;
        public MainWindow() 
        {
            InitializeComponent();
            instanceContext = new InstanceContext(this);
            clients = new KitchenService.KitchenServiceClient(instanceContext);
            clients.SendToStationBurger();
            //clients.    
           // clients.SendToStationBurger(0);
          //  clients.SendToStationBurger(0);
        }
        public void OrderBurger(Order Total)
        {
            Dispatcher.BeginInvoke(new Action(() =>
            {
                Burger.Items.Add(Total.OrderName);

            }));
            //Console.WriteLine(Total.OrderName);
        }
        public void OrderPizza(Order Total)
        {
            Dispatcher.BeginInvoke(new Action(() =>
            {
                Pizza.Items.Add(Total.OrderName +" ...   "+Total.OrderID.ToString());

            }));
           
            //Console.WriteLine(Total.OrderName);
        }
    }
}
