using System;
using Strategy.ConcreteStrategies;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            ShippingCostCalculatorService fedEx = new ShippingCostCalculatorService(new FedExShippingCostStrategy());
            var fedExShippingCost = fedEx.CalculateShippingCost();
            Console.WriteLine($"FedEx Shipping Cost: {fedExShippingCost}");

            ShippingCostCalculatorService ups = new ShippingCostCalculatorService(new UPSShippingCostStrategy());
            var upsShippingCost = ups.CalculateShippingCost();
            Console.WriteLine($"UPS Shipping Cost: {upsShippingCost}");

            ShippingCostCalculatorService usps = new ShippingCostCalculatorService(new USPSShippingCostStrategy());
            var uspsShippingCost = usps.CalculateShippingCost();
            Console.WriteLine($"USPS Shipping Cost: {uspsShippingCost}");
            Console.ReadKey();
        }
    }
}
