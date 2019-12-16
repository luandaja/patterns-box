namespace Strategy.ConcreteStrategies
{
    public class UPSShippingCostStrategy: IShippingCalculation
    {
        public double CalculateShippingCost()
        {
            return 4.25;
        }
    }
}
