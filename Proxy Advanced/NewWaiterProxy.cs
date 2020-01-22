using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy_Advanced
{
    /// <summary>
    /// The Proxy class, which can substitute for the Real Subject.
    /// </summary>
    class NewWaiterProxy : IWaiter
    {
        private string Order;
        private Waiter _waiter = new Waiter();

        public void TakeOrder(string order)
        {
            Console.WriteLine("New trainee waiter takes order for " + order + ".");
            Order = order;
        }

        public string DeliverOrder()
        {
            return Order;
        }

        public void ProcessPayment(string payment)
        {
            Console.WriteLine("New trainee cannot process payments yet!");
            _waiter.ProcessPayment(payment);
        }
    }
}
