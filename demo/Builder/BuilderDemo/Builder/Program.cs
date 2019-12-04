using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstSandwich = new SandwichMaker(new BaconSandwichBuilder());
            firstSandwich.BuildSandwich();
            var classicSandwich = firstSandwich.GetSandwich();
            classicSandwich.Display();

            var secondSandwich = new SandwichMaker(new ClubSandwichBuilder());
            secondSandwich.BuildSandwich();
            var clubSandwich = secondSandwich.GetSandwich();
            clubSandwich.Display();

            Console.ReadKey();
        }
    }
}
