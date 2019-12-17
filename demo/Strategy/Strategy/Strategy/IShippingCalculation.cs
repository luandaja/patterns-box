
namespace Strategy
{
    public interface IDeliveryProvider
    {
        double CalculateShipping();
        bool IsAplicable(DeliveryProvider shippingMethod);
    }
}