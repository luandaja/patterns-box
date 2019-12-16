namespace Strategy
{
    public class ShippingCostCalculatorService
    {
        readonly IShippingCalculation shippingCalculation;

        public ShippingCostCalculatorService(IShippingCalculation shippingCalculation)
        {
            this.shippingCalculation = shippingCalculation;
        }

        public double CalculateShippingCost()
        {
            return shippingCalculation.CalculateShippingCost();
        }
    }
}
