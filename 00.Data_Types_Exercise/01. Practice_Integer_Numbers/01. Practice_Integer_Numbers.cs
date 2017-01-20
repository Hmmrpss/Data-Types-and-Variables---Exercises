/* Задача 1: Practice Integer Numbers
Create a new C# project and create a program that assigns integer values to variables. Be sure that each value is stored in the correct variable type (try to find the most suitable variable type in order to save memory). Finally, you need to print all variables to the console.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Practice_Integer_Numbers
{
    class Program
    {
        static void Main()
        {
            sbyte firstNumber = -100;
            byte secondNumber = 128;
            short thirdNumber = -3540;
            int fourthNumber = 64876;
            long fifthNumber = 2147483648;
            long sixthNumber = -1141583228;
            decimal seventhNumber = -1223372036854775808;
            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            Console.WriteLine(thirdNumber);
            Console.WriteLine(fourthNumber);
            Console.WriteLine(fifthNumber);
            Console.WriteLine(sixthNumber);
            Console.WriteLine(seventhNumber); 
        }
    }
}
