/* Задача 11: Convert Speed Units
Create a program to ask the user for a distance (in meters) and the time taken (as three numbers: hours, minutes, seconds), and print the speed, in meters per second, kilometers per hour and miles per hour.
Assume 1 mile = 1609 meters.*/ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main()
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            decimal metersPerSecond = (decimal)(distanceInMeters / seconds);
            decimal kilometersPerHour = (decimal)(distanceInMeters / 1000) / hours;
            decimal milesPerHour = (decimal)(distanceInMeters / 1609) / hours;
            Console.WriteLine(metersPerSecond);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
            //lookup the formulas
        }
    }
}
