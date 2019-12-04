using System;
using System.Collections.Generic;

namespace Builder
{
    public class Sandwich
    {
        private readonly Breadtype breadType;
        private readonly bool isToasted;
        private readonly Chessetype chesseType;
        private readonly bool hasMustard;
        private readonly MeatType meatType;
        private readonly List<string> vegetables;
        private readonly bool hasMayo;


        public Sandwich(Breadtype breadtype, bool isToasted, Chessetype chessetype, bool hasMustard, MeatType meatType, List<string> vegetables, bool hasMayo)
        {
            this.breadType = breadtype;
            this.isToasted = isToasted;
            this.chesseType = chessetype;
            this.hasMustard = hasMustard;
            this.meatType = meatType;
            this.vegetables = vegetables;
            this.hasMayo = hasMayo;
        }

        public void Display()
        {
            Console.WriteLine("Sandwich on {0} bread", breadType);
            if (isToasted)
                Console.WriteLine("Toasted");
            if (hasMustard)
                Console.WriteLine("With Mustard");
            if (hasMayo)
                Console.WriteLine("With Mayo");
            Console.WriteLine("Meat {0}", meatType);
            Console.WriteLine("Chesse {0}", chesseType);
            Console.WriteLine("Veggies :");
            foreach (var vegetable in vegetables)
                Console.WriteLine(" {0}", vegetable);
        }

        public enum Breadtype
        {
            White,
            Wheat
        }

        public enum Chessetype
        {
            American,
            Swiss,
            Cheddar
        }

        public enum MeatType
        {
            Turkey,
            Ham,
            Chicken
        }
    }
}
