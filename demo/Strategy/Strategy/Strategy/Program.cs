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

            Console.WriteLine("Please type your delivery provider");
            //var providerSelected = int.Parse(Console.ReadLine());
            var providerSelected = Console.ReadLine();

            ShippingCostCalculatorService shippingService = new ShippingCostCalculatorService();
            var shippingCost = shippingService.CalculateTotalPrice((DeliveryProvider)providerSelected);

            Console.WriteLine($"The Shipping Fee: {shippingCost}");
            Console.ReadKey();
        }
    }
}
