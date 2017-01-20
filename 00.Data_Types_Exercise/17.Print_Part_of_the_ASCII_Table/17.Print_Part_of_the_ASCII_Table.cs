/* Задача 17: Print Part of the ASCII Table
Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints part of the ASCII table of characters at the console.  On the first line of input you will receive the char index you should start with and on the second line - the index of the last character you should print.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main()
        {
            int startingPoint = int.Parse(Console.ReadLine());
            int endingPoint = int.Parse(Console.ReadLine());
            do
            {
                
                Console.Write(((char)startingPoint) + " ");
                startingPoint++;
            } while (startingPoint <= endingPoint);
        }
    }
}
