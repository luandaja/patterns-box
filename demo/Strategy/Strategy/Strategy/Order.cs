namespace Strategy.Domain
{
    public class Order
    {
        public OrderShippingMethod OrderShippingMethod { get; set; }
        public string  Origin{ get; set; }
        public string Destination { get; set; }
    }
}
