using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy_Advanced
{
    /// <summary>
    /// The RealSubject class which the Proxy can stand in for
    /// </summary>
    public class Waiter : IWaiter
    {
        private string Order;
        public void TakeOrder(string order)
        {
            Console.WriteLine("Waiter takes order for " + order + ".");
            Order = order;
        }

        public string DeliverOrder()
        {
            return Order;
        }

        public void ProcessPayment(string payment)
        {
            Console.WriteLine("Payment for order (" + payment + ") processed.");
        }
    }
}
