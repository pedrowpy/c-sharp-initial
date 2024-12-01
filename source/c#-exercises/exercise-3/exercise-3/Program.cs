using System;
using System.Globalization;

namespace exercise3
{
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o primeiro nome:");
            string nome1 = Console.ReadLine();
            Console.WriteLine($"Digite a idade de {nome1}");
            int idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo nome:");
            string nome2 = Console.ReadLine();
            Console.WriteLine($"Digite a idade de {nome2}");
            int idade2 = int.Parse(Console.ReadLine());

            double media = (double) (idade1 + idade2) / 2.0;

            Console.WriteLine($"A idade média de {nome1} e {nome2} é de {media.ToString("F1", CultureInfo.InvariantCulture)} anos");
        }
    }
}