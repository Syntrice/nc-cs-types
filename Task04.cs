using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NcCsTypes
{
    internal class Task04
    {
        public static void Run()
        {
            Console.WriteLine("Please enter a int value:");
            int intInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a decimal value:");
            decimal decimalInput = decimal.Parse(Console.ReadLine());

            double result = intInput / (double)decimalInput;

            Console.WriteLine("Would you like the answer returned as a char array? [true, false]");

            bool boolInput = bool.Parse(Console.ReadLine());

            if (boolInput)
            {
                // to char array
                Console.WriteLine(result.ToString().ToCharArray());

            }
            else
            {
                // return int as is
                Console.WriteLine(result);
            }
            
        }
    }
}
