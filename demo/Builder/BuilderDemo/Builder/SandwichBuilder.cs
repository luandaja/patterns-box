namespace Builder
{
    public abstract class SandwichBuilder
    {
        protected Sandwich sandwich;

        public Sandwich GetSandwich()
        {
            return sandwich;
        }

        public void CreateNewSandwich()
        {
            sandwich = new Sandwich();
        }

        public abstract void PrepareBread();
        public abstract void ApplyMeatandChesse();
        public abstract void ApplyVegetables();
        public abstract void AddCondiments();
    }
}
