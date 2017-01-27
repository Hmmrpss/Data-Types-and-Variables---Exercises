/* Задача 15: Fast Prime Checker - Refactor
You are given a program that checks if numbers in a given range [2...N] are prime. For each number is printed "{number} is prime -> {True or False}". The code however, is not very well written. Your job is to modify it in a way that is easy to read and understand.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker___Refactor
{
    class Program
    {
        static void Main()
        {
            int numberToCheck = int.Parse(Console.ReadLine());
            for (int check = 2; check <= numberToCheck; check++)
            {
                bool primeNumber = true;
                for (int division = 2; division <= Math.Sqrt(check); division++)
                {
                    if (check % division == 0)
                    {
                        primeNumber = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", check, primeNumber);
            }
        }
    }
}


