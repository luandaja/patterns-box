using System.Collections.Generic;
using static Builder.Sandwich;

namespace Builder
{
    public class BaconSandwichBuilder : SandwichBuilder
    {
        public override void AddCondiments()
        {
            sandwich.hasMayo = false;
            sandwich.hasMustard = true;
        }

        public override void ApplyMeatandChesse()
        {
            sandwich.chesseType = Chessetype.American;
            sandwich.meatType = MeatType.Turkey;
        }

        public override void ApplyVegetables()
        {
            sandwich.vegetables = new List<string> { "Tomato", "Onion" };
        }

        public override void PrepareBread()
        {
            sandwich.breadType = Breadtype.White;
            sandwich.isToasted = true;
        }
    }
}
