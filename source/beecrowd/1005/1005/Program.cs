using System;
using System.Globalization;

namespace beecrowd1005
{
    internal class Program {
        static void Main(string[] args) {
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double media = ((a * 3.5) + (b * 7.5)) / 11;
            Console.WriteLine($"MEDIA = {media.ToString("F5", CultureInfo.InvariantCulture)}");
        }
    }
}