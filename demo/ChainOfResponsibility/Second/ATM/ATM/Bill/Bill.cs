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

        public int Withdral(int amount)
        {
            int numberOfBills = amount / Denomination;
            int remaining = amount % Denomination;
            Console.WriteLine($"Dispensing {numberOfBills} bills of {Denomination}$");
            return remaining;
        }

    }
}
