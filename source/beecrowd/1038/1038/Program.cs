using System;
using System.Globalization;

namespace beecrowd1038 {
    internal class Program {
        static void Main(string[] args) {

            string[] vet = Console.ReadLine().Split(' ');

            if (vet.Length == 2 &&
            int.TryParse(vet[0], out int c) &&
            int.TryParse(vet[1], out int q)) {

                double p;

                switch (c) {
                    case 1:
                        p = 4.00;
                        break;
                    case 2:
                        p = 4.50;
                        break;
                    case 3:
                        p = 5.00;
                        break;
                    case 4:
                        p = 2.00;
                        break;
                    case 5:
                        p = 1.50;
                        break;
                    default:
                        Console.WriteLine("Código inválido.");
                        return;
                }
                double total = (double)p * q;

                Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
            } else {
                Console.WriteLine("Insira um valor válido!");
            }


            }
        }
}