/* Задача 5: Boolean Variable
Write a program that reads a string, converts it to Boolean variable and prints “Yes” if the variable is true and “No” if the variable is false.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Boolean_Variable
{
    class Program
    {
        static void Main()
        {
            string inputString = Console.ReadLine();
            bool truthChecker = Convert.ToBoolean(inputString);
            if (inputString == "True")
            {
                Console.WriteLine("Yes");  
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
