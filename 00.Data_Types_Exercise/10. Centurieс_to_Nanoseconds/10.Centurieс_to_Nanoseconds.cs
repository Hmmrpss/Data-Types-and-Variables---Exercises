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
            int centuries = int.Parse(Console.ReadLine());
            int years = (int)(centuries * TimeConstants.yearsInOneCenturies);
            int days = (int)(years * TimeConstants.daysInOneYear);
            long hours = (long)(days * TimeConstants.hoursInOneDay);
            long minutes = (long)(hours * TimeConstants.minutesInOneHour);
            long seconds = (long)(minutes * TimeConstants.secondsInOneMinute);
            BigInteger milliseconds = (BigInteger)(seconds * TimeConstants.milliSecondsInOneSecond);
            BigInteger microseconds = (BigInteger)(milliseconds * TimeConstants.microSecondsInOneMilliSecond);
            BigInteger nanoseconds = (BigInteger)(microseconds * TimeConstants.nanoSecondsInOneMicroSecond);
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
    static class TimeConstants
    {
        public const byte yearsInOneCenturies = 100;
        public const double daysInOneYear = 365.2422;
        public const byte hoursInOneDay = 24;
        public const byte minutesInOneHour = 60;
        public const byte secondsInOneMinute = 60;
        public const ushort milliSecondsInOneSecond = 1000;
        public const ushort microSecondsInOneMilliSecond = 1000;
        public const ushort nanoSecondsInOneMicroSecond = 1000;
    }
}
