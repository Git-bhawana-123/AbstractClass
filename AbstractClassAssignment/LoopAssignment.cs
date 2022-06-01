using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    internal class LoopAssignment
    {
        static void Main()
        {
            string[] cities = new string[6];
            Console.WriteLine("Enter the cities");
            for (int i = 0; i < cities.Length; i++)
            {
                cities[i] = Console.ReadLine();
            }
            string[] copyData = new string[cities.Length];
            cities.CopyTo(cities, 0);
            Console.WriteLine("All the cities are:");
            foreach(string i in cities)
            {
                Console.WriteLine(i);
            }
            var output =(Array)cities.Clone();
            foreach(var item in output)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("cites are"+ " "+ cities.GetValue(2));
        }
    }
}
