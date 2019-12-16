using System;
using Strategy.Domain;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var shippingCalculatorService = new ShippingCostCalculatorService();
            var fedExOrder = OrderService.CreateFedExOrder();
            var fedExShippingCost = shippingCalculatorService.CalculateShippingCost(fedExOrder);
            Console.WriteLine($"FedEx Shipping Cost: {fedExShippingCost}");

            var upsOrder = OrderService.CreateUPSOrder();
            var upsShippingCost = shippingCalculatorService.CalculateShippingCost(upsOrder);
            Console.WriteLine($"UPS Shipping Cost: {upsShippingCost}");


            var upsShippingOrderr = OrderService.CreateUSPSOrder();
            var uspsShippingCost = shippingCalculatorService.CalculateShippingCost(upsShippingOrderr);
            Console.WriteLine($"USPS Shipping Cost: {uspsShippingCost}");
            Console.ReadKey();
        }
    }
}
