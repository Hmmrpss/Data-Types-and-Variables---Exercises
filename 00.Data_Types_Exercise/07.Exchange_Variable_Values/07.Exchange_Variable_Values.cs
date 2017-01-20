/* Задача 7: Exchange Variable Values
Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic. Print the variable values before and after the exchange,*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Exchange_Variable_Values
{
    class Program
    {
        static void Main()
        {
            int firstVariable = 5;
            int secondVariable = 10;
            int newFirst = secondVariable;
            int newSecond = firstVariable;
            Console.WriteLine("Before: \na = {0}\nb = {1}\nAfter:\na = {2}\nb = {3}", firstVariable, secondVariable, newFirst, newSecond);

        }
    }
}
