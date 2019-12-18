namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            //var dispenser = GetATMDispenser();
            var dispenser = GetATMDispenserBug();

            dispenser.Dispense(160);

        }

        private static Dispenser GetATMDispenserBug()
        {
            var bill50Dispenser = new Dispenser(new Bill(50));
            var bill20Dispenser = new Dispenser(new Bill(20));

            bill50Dispenser.SetNext(bill20Dispenser);
            return bill50Dispenser;
        }

        private static Dispenser GetATMDispenser()
        {
            //var bill100Dispenser = new Dispenser(new Bill(100));
            var bill50Dispenser = new Dispenser(new Bill(50));
            var bill20Dispenser = new Dispenser(new Bill(20));
            var bill10Dispenser = new Dispenser(new Bill(10));

            //bill100Dispenser.SetNext(bill50Dispenser);
            bill50Dispenser.SetNext(bill20Dispenser);
            bill20Dispenser.SetNext(bill10Dispenser);
            return bill50Dispenser;
        }
    }
}
