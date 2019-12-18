using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            var dispenser = GetATMDispenser();

            dispenser.Dispense(160);

        }

        private  static Dispenser GetATMDispenser()
        {
            var bill50Dispenser = new Bill50Dispenser();
            var bill20Dispenser = new Bill20Dispenser();
            var bill10Dispenser = new Bill10Dispenser();

            bill10Dispenser.SetNext(bill20Dispenser);
            bill20Dispenser.SetNext(bill50Dispenser);
            return bill10Dispenser;
        }
    }
}
