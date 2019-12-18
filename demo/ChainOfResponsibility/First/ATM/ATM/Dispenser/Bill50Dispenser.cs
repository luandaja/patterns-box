using System;

namespace ATM
{
    public class Bill50Dispenser : Dispenser
    {
        public override void Dispense(int amount)
        {
            if (amount < 50)
                _next.Dispense(amount);
            else
            {
                int numberOfBills = amount / 50;
                int remainder = amount % 50;
                Console.WriteLine($"Dispensing {numberOfBills} bills of 50$");
                if (remainder != 0)
                {
                    _next.Dispense(remainder);
                }
            }

        }
    }
}
