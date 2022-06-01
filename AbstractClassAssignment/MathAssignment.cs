using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    internal class MathAssignment
    {
        static void Main()
        {
            var x = 6646.2323M;
            var y = 2324.2323;

            Console.WriteLine($"Rounding to decimal value{ Math.Round(x, 2)}");
            Console.WriteLine($"Ceiling:{Math.Ceiling(y)}");
            Console.WriteLine($"Floor:{ Math.Floor(y)}");
            Console.WriteLine($"POW:{Math.Pow(2, 4)}");
            Console.WriteLine($"Abs:{Math.Max(15.22, 12.22)}");
            Console.WriteLine($"Sqrt:{Math.Sqrt(81)}");
            Console.Read();
        }
    }
}
