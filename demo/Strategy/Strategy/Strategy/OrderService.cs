namespace Strategy.Domain
{
    public class OrderService
    {
        public static Order CreateFedExOrder()
        {
            return new Order()
            {
                OrderShippingMethod = OrderShippingMethod.FedEx
            };
        }

        public static Order CreateUPSOrder()
        {
            return new Order()
            {
                OrderShippingMethod = OrderShippingMethod.UPS
            };
        }

        public static Order CreateUSPSOrder()
        {
            return new Order()
            {
                OrderShippingMethod = OrderShippingMethod.USPS
            };
        }
    }
}
