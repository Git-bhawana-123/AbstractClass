using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    internal class DifferenceIntParseandConvertToInt
    {
        static void Main()
        {
            int result;
            string str = "1234";
            //string str2 = null;//not allowed passing a null value to int Parse will throw an ArgumentNullException 
            result = int.Parse(str);
            Console.WriteLine(result);


            int sum;
            string stri = null ;//allowed
            sum = Convert.ToInt32(stri);
            Console.WriteLine(sum);
            
            Console.Read();
            
        }
    }
}
