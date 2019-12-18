using System;

namespace ATM
{
    public class Bill10Dispenser : Dispenser
    {
        public override void Dispense(int amount)
        {
            if (amount < 10)
                _next.Dispense(amount);
            else
            {
                int numberOfBills = amount / 10;
                int remainder = amount % 10;
                Console.WriteLine($"Dispensing {numberOfBills} bills of 10$");
                if (remainder != 0)
                {
                    _next.Dispense(remainder);
                }
            }
        }
    }
}
