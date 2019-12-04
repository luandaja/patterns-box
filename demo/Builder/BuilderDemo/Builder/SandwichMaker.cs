namespace Builder
{
    public class SandwichMaker
    {
        private readonly SandwichBuilder builder;

        public SandwichMaker(SandwichBuilder builder)
        {
            this.builder = builder;
        }

        public void BuildSandwich()
        {
            builder.CreateNewSandwich();
            builder.PrepareBread();
            builder.ApplyMeatandChesse();
            builder.ApplyVegetables();
            builder.AddCondiments();
        }

        public Sandwich GetSandwich()
        {
            return builder.GetSandwich();
        }
    }
}
