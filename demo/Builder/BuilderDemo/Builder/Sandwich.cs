using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Sandwich
    {
        public Breadtype breadType { get; set; }
        public bool isToasted { get; set; }
        public Chessetype chesseType { get; set; }
        public bool hasMustard { get; set; }
        public MeatType meatType { get; set; }
        public List<string> vegetables { get; set; }
        public bool hasMayo { get; set; }

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
