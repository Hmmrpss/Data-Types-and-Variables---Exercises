﻿/* Задача 13: Vowel or Digit
Create a program to check if given symbol is digit, vowel or any other symbol.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main()
        {
            char givenSymbol = char.Parse(Console.ReadLine());
            switch (givenSymbol)
            {
               case '0':
               case '1':
               case '2':
               case '3':
               case '4':
               case '5':
               case '6':
               case '7':
               case '8':
               case '9':
                   Console.WriteLine("digit");
                   break;
               case 'a':
               case 'o':
               case 'u':
               case 'e':
               case 'i':
               case 'y':
                    Console.WriteLine("vowel");
                    break;
               default:
                    Console.WriteLine("other");
                    break;
            }
        }
    }
}
