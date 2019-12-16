namespace Strategy.ConcreteStrategies
{
    public class FedExShippingCostStrategy: IShippingCalculation
    {
        public double CalculateShippingCost()
        {
            return 7.5;
        }
    }
}
