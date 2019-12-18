namespace ATM
{
    public interface IDispenser
    {
        void SetNext(IDispenser next);

        int Dispense(int amount);
    }
}
