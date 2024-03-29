﻿using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create IBM stock and attach investors
            IBM ibm = new IBM("IBM", 120.00);
            ibm.Attach(new Investor("Sorros"));
            ibm.Attach(new Investor("Berkshire"));

            // Fluctuating prices will notify investors
            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = Convert.ToDouble(Console.ReadLine());

            // Wait for user
            Console.ReadKey();
        }
    }
}
