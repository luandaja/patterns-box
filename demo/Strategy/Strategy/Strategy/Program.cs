using System;
using System.Collections;
using System.Collections.Generic;
using Strategy.ConcreteStrategies;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please type your delivery provider \nFedEx: 1 \nUPS: 2 \nUSPS: 3");
            var providerSelected = int.Parse(Console.ReadLine());

            ShippingCostCalculatorService shippingService = new ShippingCostCalculatorService();
            var shippingCost = shippingService.CalculateTotalPrice((DeliveryProvider)providerSelected);

            Console.WriteLine($"The total price is : {shippingCost} for this provider");
            Console.ReadKey();
        }
    }
}
