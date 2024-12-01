using System;
using System.Globalization;

namespace beecrowd1014 {
    internal class Program {
        static void Main(string[] args) {
            int a = int.Parse(Console.ReadLine());
            double km = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double kml = (double)a / km;

            Console.WriteLine($"{kml.ToString("F3", CultureInfo.InvariantCulture)} km/l");
        }
    }
}