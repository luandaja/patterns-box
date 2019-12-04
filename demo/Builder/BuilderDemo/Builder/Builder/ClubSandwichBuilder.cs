using Builder.Enumerables;
using System.Collections.Generic;

namespace Builder
{
    public class ClubSandwichBuilder : SandwichBuilder
    {
        private Sandwich _sandwich;
        public ClubSandwichBuilder()
        {
            _sandwich = new Sandwich();
        }

        public ClubSandwichBuilder AddCondiments(List<string> condiments)
        {
            _sandwich.Condiments = condiments;
            return this;
        }

        public ClubSandwichBuilder ApplyMeatandChesse()
        {
            _sandwich.chesseType = ChesseType.Swiss;
            _sandwich.meatType = MeatType.Turkey;
            return this;
        }
        public ClubSandwichBuilder ApplyVegetables(List<string> vegetables)
        {
            _sandwich.Vegetables = vegetables;
            return this;
        }
        public ClubSandwichBuilder PrepareBread(Breadtype breadtype)
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
