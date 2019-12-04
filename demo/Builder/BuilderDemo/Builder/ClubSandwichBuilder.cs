using System.Collections.Generic;
using static Builder.Sandwich;

namespace Builder
{
    public class ClubSandwichBuilder : SandwichBuilder
    {
        public override void AddCondiments()
        {
            sandwich.hasMayo = true;
            sandwich.hasMustard = true;
        }

        public override void ApplyMeatandChesse()
        {
            sandwich.chesseType = Chessetype.Swiss;
            sandwich.meatType = MeatType.Turkey;
        }

        public override void ApplyVegetables()
        {
            sandwich.vegetables = new List<string> { "Tomato", "Onion", "Lettuce" };
        }

        public override void PrepareBread()
        {
            sandwich.breadType = Breadtype.White;
            sandwich.isToasted = true;
        }
    }
}
