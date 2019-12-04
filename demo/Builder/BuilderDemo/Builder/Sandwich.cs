using Builder.Enumerables;
using System;
using System.Collections.Generic;

namespace Builder
{
    public class Sandwich
    {
        public Breadtype breadType { get; set; }
        public bool IsToasted { get; set; }
        public ChesseType chesseType { get; set; }
        public bool HasMustard { get; set; }
        public MeatType meatType { get; set; }
        public List<string> Vegetables { get; set; }
        public List<string> Condiments { get; set; }

        public void Display()
        {
            Console.WriteLine("Sandwich on {0} bread", breadType);
            if (IsToasted)
                Console.WriteLine("Toasted");
            Console.WriteLine("With Mustard");
            Console.WriteLine("With Mayo");
            foreach (var condiment in Condiments)
                Console.WriteLine(" {0}", condiment);

            Console.WriteLine("Meat {0}", meatType);
            Console.WriteLine("Chesse {0}", chesseType);
            Console.WriteLine("Veggies :");
            foreach (var vegetable in Vegetables)
                Console.WriteLine(" {0}", vegetable);
        }
    }
}
