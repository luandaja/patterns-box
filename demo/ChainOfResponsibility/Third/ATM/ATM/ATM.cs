using System;

namespace ATM
{
    class ATM
    {
        static void Main(string[] args)
        {
            //var dispenser = GetATMDispenser();
            var dispenser = GetATMDispenserBug();
            Console.WriteLine("Welcome to ATM");
            while (true)
            {               
                Console.WriteLine("=================================================");
                Console.WriteLine("Enter the amount you want to withdrawal:");
                int amount = Convert.ToInt32(Console.ReadLine());

                //if (amount % 10 != 0)
                //{
                //    Console.WriteLine("***Please enter an amount multiple of 10!");
                //}

                int remaining = dispenser.Dispense(amount);
                Console.WriteLine($"ATM could not dispense {remaining} $");
            }
                      
        }

        private  static Dispenser GetATMDispenserBug()
        {
            var bill50Dispenser = new Dispenser(new Bill(50));
            var bill20Dispenser = new Dispenser(new Bill(20));

            bill50Dispenser.SetNext(bill20Dispenser);
            return bill50Dispenser;
        }

        private static Dispenser GetATMDispenser()
        {
            var bill50Dispenser = new Dispenser(new Bill(50));
            var bill20Dispenser = new Dispenser(new Bill(20));
            var bill10Dispenser = new Dispenser(new Bill(10));
            var bill5Dispenser = new Dispenser(new Bill(5));
            //var bill1Dispenser = new Dispenser(new Bill(1));

            bill50Dispenser.SetNext(bill20Dispenser);
            bill20Dispenser.SetNext(bill10Dispenser);
            bill10Dispenser.SetNext(bill5Dispenser);
            //bill5Dispenser.SetNext(bill1Dispenser);
            return bill50Dispenser;
        }
    }
}
