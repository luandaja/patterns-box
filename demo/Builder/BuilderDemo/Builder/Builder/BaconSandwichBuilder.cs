using Builder.Enumerables;
using System.Collections.Generic;

namespace Builder
{
    public class BaconSandwichBuilder : SandwichBuilder
    {
        private Sandwich _sandwich;
        public BaconSandwichBuilder()
        {
            _sandwich = new Sandwich();
        }

        public BaconSandwichBuilder AddCondiments(List<string> condiments)
        {
            _sandwich.Condiments = condiments;
            return this;
        }

        public BaconSandwichBuilder ApplyMeatandChesse()
        {
            _sandwich.chesseType = ChesseType.American;
            _sandwich.meatType = MeatType.Turkey;
            return this;
        }
        public BaconSandwichBuilder ApplyVegetables(List<string> vegetables)
        {
            _sandwich.Vegetables = vegetables;
            return this;
        }
        public BaconSandwichBuilder PrepareBread(Breadtype breadtype)
        {
            _sandwich.breadType = breadtype;
            return this;
        }
        public override Sandwich Build()
        {
            return _sandwich;
        }
    }
}
