namespace Strategy.ConcreteStrategies
{
    public class USPSShippingCostStrategy: IDeliveryProvider
    {
        public double CalculateShipping()
        {
            return 4.25;
        }

        public bool IsAplicable(DeliveryProvider shippingMethod)
        {
            return shippingMethod == DeliveryProvider.USPS;
        }
    }
}
