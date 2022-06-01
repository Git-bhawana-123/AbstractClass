using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    internal class StringBuilderAssignment
    {
        static void Main()
        {
           
            StringBuilder sb = new StringBuilder("ABC");
            StringBuilder src = new StringBuilder("Today is a very good day");

            sb.Append(new char[] { 'D', 'E', 'F' });

            // Append a format string to the end of the StringBuilder.
            sb.AppendFormat("GHI{0}{1}", 'J', 'k');

            // Display the number of characters in the StringBuilder and its string.
            Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());

            // Insert a string at the beginning of the StringBuilder.
            sb.Insert(0, "Alphabet: ");

            // Replace all lowercase k's with uppercase K's.
            sb.Replace('k', 'Z');

            Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());
            char[] dest = { 'H', 'e', 'l', 'l', 'o', ' ',
                           'W', 'o', 'r', 'l', 'd' };
            src.CopyTo(5, dest, 0, 3);

            Console.Write("The Copied String in " +
                            "dest Variable is: ");


            Console.WriteLine(dest);

            src.Remove(6, 3);
            Console.WriteLine("{0}", src.ToString());
            src.Clear();
            Console.WriteLine("{0}", src.ToString());
        }







    }

        
        
    
}
