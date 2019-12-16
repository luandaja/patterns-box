namespace Strategy.ConcreteStrategies
{
    public class USPSShippingCostStrategy: IShippingCalculation
    {
        public double CalculateShippingCost()
        {
            return 4.25;
        }
    }
}
