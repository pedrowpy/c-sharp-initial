using System;
using System.Globalization;

namespace beecrowd1011
{
    internal class Program {
        static void Main(string[] args) {
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double volume = (double) (4 / 3.0) * 3.14159 * Math.Pow(raio, 3.0);
            Console.WriteLine($"VOLUME = {volume.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}