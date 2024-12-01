using System;
using System.Globalization;

namespace beecrowd1009
{
    internal class Program {
        static void Main(string[] args) {
            string nome = Console.ReadLine();
            double salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double totalVenda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioTotal = (double)(totalVenda * 15.0) / 100 + salarioFixo;

            Console.WriteLine($"TOTAL = R$ {salarioTotal.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}