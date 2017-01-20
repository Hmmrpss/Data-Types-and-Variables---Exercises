/* Задача 10: Centuries to Nanoseconds
Write program to enter an integer number of centuries and convert it to years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.Centurieс_to_Nanoseconds
{
    class Program
    {
        static void Main()
        {
            byte centuries = byte.Parse(Console.ReadLine());
            short years = (short)(centuries * 100);
            int days = (int)(Math.Round(years * 365.2422));
            int hours = (int)(days * 24);
            uint minutes = (uint)(hours * 60);
            ulong seconds = (ulong)(hours * 60);
            ulong milliseconds = (ulong)(seconds * 60);
            bigInteger microseconds = milliseconds * 60;
            bigInteger nanoseconds = microseconds * 60;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",
                centuries,
                years, 
                days,
                hours,
                minutes,
                seconds,
                milliseconds,
                microseconds,
                nanoseconds);
        }
    }
}
