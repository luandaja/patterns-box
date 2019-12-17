namespace Strategy.ConcreteStrategies
{
    public class FedExShippingCostStrategy: IDeliveryProvider
    {
        public double CalculateShipping()
        {
            return 7.5;
        }

        public bool IsAplicable(DeliveryProvider shippingMethod)
        {
            return shippingMethod == DeliveryProvider.FedEx;
        }
    }
}
