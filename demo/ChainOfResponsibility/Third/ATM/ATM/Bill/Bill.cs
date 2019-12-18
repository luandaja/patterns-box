using System;

namespace ATM
{
    public class Bill : IBill
    {
        public Bill(int denomination)
        {
            Denomination = denomination;
        }

        public int Denomination
        {
            get; private set;
        }

        public int WithdrawBills(int amount)
        {
            int numberOfBills = amount / Denomination;           
            Console.WriteLine($"Dispensing {numberOfBills} bills of {Denomination}$");
            return amount % Denomination;
        }
    }
}
