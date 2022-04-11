using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;

            var div = a / b;
            var mod = a % b;
            
            Console.WriteLine($"{a}/{b} is {div} remainder {mod}");

            Console.WriteLine("What is the radius of your circle?");
#pragma warning disable CS8604 // Possible null reference argument.
            var radius = double.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.

            var calculateArea = AreaOfCircle(radius);

            Console.WriteLine($"The area of a circle with a radius of {radius} is {calculateArea}");
        }
        public static double AreaOfCircle(double radius)
        {
            return Math.PI * (radius * radius);
        }
    }
}