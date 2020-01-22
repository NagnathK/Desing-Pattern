using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    /// <summary>
    /// A Concrete Strategy class
    /// </summary>
    class DeepFrying : CookStrategy
    {
        public override void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by deep frying it");
        }
    }
}
