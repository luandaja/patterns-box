namespace ATM
{
    public abstract class Dispenser : IDispenser
    {
        protected IDispenser _next;
        public void SetNext(IDispenser next)
        {
            _next = next;
        }
        public abstract void Dispense(int amount);
    }
}