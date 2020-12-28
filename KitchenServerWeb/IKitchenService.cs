using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KitchenWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IKitchenService" in both code and config file together.
    [ServiceContract(CallbackContract = typeof(IReportServiceCallback))]
    public interface IKitchenService
    {
        [OperationContract(IsOneWay = true)]
        void SendToStationBurger();

    }
     public interface IReportServiceCallback
    {
        // Since we have not set IsOnway=true, the operation is Request/Reply operation
        [OperationContract(IsOneWay = true)]
        void OrderBurger(Order Total);
        [OperationContract(IsOneWay = true)]
        void OrderPizza(Order Total);
    }
}
