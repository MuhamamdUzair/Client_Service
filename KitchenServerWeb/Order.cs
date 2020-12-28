using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenWebService
{
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
