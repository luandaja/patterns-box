namespace ATM
{
    public interface IDispenser
    {
        void SetNext(IDispenser next);

        void Dispense(int amount);
    }
}
