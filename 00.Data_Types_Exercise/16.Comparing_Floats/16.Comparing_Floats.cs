/* Задача 16: Comparing Floats
Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than some fixed constant eps. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Comparing_Floats
{
    class Program
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double largerNumber = 0;
            double lesserNumber = 0;
            if (firstNumber > secondNumber)
            {
                largerNumber = firstNumber;
                lesserNumber = secondNumber;
            }
            else
	        {
                largerNumber = secondNumber;
                lesserNumber = firstNumber;
	        }
            double eps = 0.000001;
            double difference = largerNumber - lesserNumber;
            if (difference < eps)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
