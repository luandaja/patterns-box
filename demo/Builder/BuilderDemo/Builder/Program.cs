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
            new Sandwich(Breadtype.Wheat, false, Chessetype.American, false, MeatType.Ham,
                new List<string> { "Tomato" }, false).Display();

            Console.ReadKey();
        }
    }
}
