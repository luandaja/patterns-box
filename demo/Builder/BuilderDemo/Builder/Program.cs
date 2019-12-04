using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Builder.Sandwich;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var sandwich = new Sandwich();
            sandwich.breadType = Breadtype.Wheat;
            sandwich.chesseType = Chessetype.American;
            sandwich.meatType = MeatType.Turkey;
            sandwich.isToasted = true;
            sandwich.hasMustard = true;
            sandwich.hasMayo = false;
            sandwich.vegetables = new List<string> { "Tomato", "Onion" };
            sandwich.Display();
            Console.ReadKey();
        }
    }
}
