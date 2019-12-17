namespace Strategy.ConcreteStrategies
{
    public class UPSShippingCostStrategy: IDeliveryProvider
    {
        public double CalculateShipping()
        {
            return 4.25;
        }

        public bool IsAplicable(DeliveryProvider shippingMethod)
        {
            return shippingMethod == DeliveryProvider.UPS;
        }
    }
}
