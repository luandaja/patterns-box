namespace ATM
{
    public interface IBill
    {
        int WithdrawBills(int amount);
        int Denomination { get; }
    }
}
