using Strategy.Domain;

namespace Strategy
{
    public class ShippingCostCalculatorService
    {
        public double CalculateShippingCost(Order order)
        {
            switch (order.OrderShippingMethod)
            {
                case OrderShippingMethod.FedEx:
                    return CalcularForFedEx(order);

                case OrderShippingMethod.UPS:
                    return CalcularForUPS(order);

                case OrderShippingMethod.USPS:
                    return CalcularForUSPS(order);
                default:
                    return 0;
            }
        }

        private double CalcularForUSPS(Order order)
        {
            return 3.00;
        }

        private double CalcularForUPS(Order order)
        {
            return 4.25;
        }

        private double CalcularForFedEx(Order order)
        {
            return 7.5;
        }
    }
}
