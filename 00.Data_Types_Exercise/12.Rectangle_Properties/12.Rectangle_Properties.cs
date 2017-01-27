/* Задача 12: Rectangle Properties
Create a program to calculate rectangle’s perimeter, area and diagonal by given its width and height.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Rectangle_Properties
{
    class Program
    {
        static void Main()
        {
            double rectangleWidth = double.Parse(Console.ReadLine());
            double rectangleHeidht = double.Parse(Console.ReadLine());
            double rectanglePerimeter = 2 * (rectangleWidth + rectangleHeidht);
            double rectangleArea = rectangleWidth * rectangleHeidht;
            double rectangleDiagonal = Math.Sqrt(Math.Pow(rectangleWidth, 2) + Math.Pow(rectangleHeidht, 2));
            Console.WriteLine(rectanglePerimeter);
            Console.WriteLine(rectangleArea);
            Console.WriteLine(rectangleDiagonal);
        }
    }
}
