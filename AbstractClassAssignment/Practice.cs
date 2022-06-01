using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
   
    internal class Practice
    {
        enum MaterialColours
        {
            Blue = 1,
            Red,
            Yellow = 4,
            Purple = Blue | Red,
            Green = Yellow | Blue,
            Orange = Red | Yellow
        }


        static void Main(string[] args)
        {
            Console.WriteLine((int)MaterialColours.Orange);

            Console.Read();
        }
    }
}
