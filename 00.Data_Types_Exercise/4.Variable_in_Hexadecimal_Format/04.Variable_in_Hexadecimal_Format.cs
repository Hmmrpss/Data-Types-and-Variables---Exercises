/* Задача 4: Variable in Hexadecimal Format
Write a program that reads a number in hexadecimal format (0x##) convert it to decimal format and prints it.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main()
        {
            string hexadecimalNumber = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(hexadecimalNumber, 16));
        }
    }
}
