/* Задача 9: Reverse Characters
Write a program to ask the user for 3 letters and print them in reversed order.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Reverse_Characters
{
    class Program
    {
        static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{2}", thirdChar, secondChar, firstChar);
        }
    }
}
