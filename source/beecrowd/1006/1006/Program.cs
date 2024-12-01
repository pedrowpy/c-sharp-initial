using System;
using System.Globalization;

namespace beecrowd1006
{
    internal class Program {
        static void Main(string[] args) {
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = ((a * 2) + (b * 3) + (c * 5)) / 10;
            Console.WriteLine($"MEDIA = {media.ToString("F1", CultureInfo.InvariantCulture)}");
        }
    }
}