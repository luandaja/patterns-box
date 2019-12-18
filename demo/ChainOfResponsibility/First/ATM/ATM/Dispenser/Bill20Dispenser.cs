using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    public class Bill20Dispenser : Dispenser
    {
        public override void Dispense(int amount)
        {
            if (amount < 20)
                _next.Dispense(amount);
            else
            {
                int numberOfBills = amount / 20;
                int remainder = amount % 20;
                Console.WriteLine($"Dispensing {numberOfBills} bills of 20$");
                if (remainder != 0)
                {
                    _next.Dispense(remainder);
                }
            }
        }
    }
}
