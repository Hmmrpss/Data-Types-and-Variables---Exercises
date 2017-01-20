/* Задача 2: Practice Floating Point Numbers
Create a new C# project and create a program that assigns floating point values to variables. Be sure that each value is stored in the correct variable type (try to find the most suitable variable type in order to save memory). Finally, you need to print all variables to the console.*/ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Practice_Floating_Point_Numbers
{
    class Program
    {
        static void Main()
        {
            decimal firstNumber = 3.141592653589793238M;
            double secondNumber = 1.60217657;
            decimal thirdNumber = 7.8184261974584555216535342341M;
            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            Console.WriteLine(thirdNumber);



        }
    }
}
