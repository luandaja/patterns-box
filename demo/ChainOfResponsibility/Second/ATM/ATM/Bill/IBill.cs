namespace ATM
{
    public interface IBill
    {
        int Withdral(int amount);
        int Denomination { get; }
    }
}
