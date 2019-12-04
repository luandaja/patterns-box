using Builder.Enumerables;
using System;
using System.Collections.Generic;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {

            var baconSandwichbuilder = new BaconSandwichBuilder();
            var baconSandwich = baconSandwichbuilder
                .PrepareBread(Breadtype.White)
                .ApplyMeatandChesse()
                .ApplyVegetables(new List<string> { "Tomato", "Onions" })
                .AddCondiments(new List<string> { "Mayo", "Mustard" })
                .Build();
            baconSandwich.Display();

            var clubSandwichbuilder = new ClubSandwichBuilder();
            var clubSandwich = clubSandwichbuilder
                .PrepareBread(Breadtype.Wheat)
                .ApplyMeatandChesse()
                .ApplyVegetables(new List<string> { "Lettuce" })
                .AddCondiments(new List<string> { "Mayo" })
                .Build();
            clubSandwich.Display();

            Console.ReadKey();
        }
    }
}
