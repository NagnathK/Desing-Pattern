using System;

namespace Proxy_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var newProxy = new NewWaiterProxy();
            newProxy.TakeOrder("Panner tikka masala");
            var order = newProxy.DeliverOrder();

            Console.WriteLine("Order {0}", order);

            newProxy.ProcessPayment("Panner tikka masala");

            Console.ReadKey();
        }
    }
}
