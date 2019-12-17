using Strategy.ConcreteStrategies;
using System;
using System.Collections.Generic;

namespace Strategy
{
    public class ShippingCostCalculatorService
    {
        readonly List<IDeliveryProvider> deliveryProviders;
        public double Price { get; set; }

        public ShippingCostCalculatorService()
        {
            deliveryProviders = new List<IDeliveryProvider>
            {
                new FedExShippingCostStrategy(),
                new UPSShippingCostStrategy(),
                new USPSShippingCostStrategy()
            };
        }

        public double CalculateTotalPrice(DeliveryProvider provider)
        {
            return Price + GetProviderFee(provider);
        }

        private double GetProviderFee(DeliveryProvider provider)
        {
            foreach (var deliveryProvider in deliveryProviders)
            {
                if (deliveryProvider.IsAplicable(provider))
                {
                    return deliveryProvider.CalculateShipping();
                }
            }
            throw new ApplicationException("The selected shipping method is not valid");
        }
    }
}
