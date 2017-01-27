/* Задача 14: Integer to Hex and Binary
Create a program to convert a decimal number to hexadecimal and binary number and print it.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main()
        {
            int decimalNumber = int.Parse(Console.ReadLine());
            string hexadecimalNumber = (Convert.ToString(decimalNumber, 16));
            string binaryNumber = (Convert.ToString(decimalNumber, 2));
            Console.WriteLine(hexadecimalNumber.ToUpper());
            Console.WriteLine(binaryNumber);
        }
    }
}
