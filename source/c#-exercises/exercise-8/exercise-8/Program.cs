using System;
using System.Globalization;

namespace exercise8 {
    internal class Program {
        static void Main(string[] args) {
            double idade, soma, media;
            int count;
            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            soma = 0.0;
            count = 0;
            while (idade > 0) {
                soma = soma + idade;
                count = count + 1;
                idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            if (count == 0) {
                Console.WriteLine("Impossivel calcular");
            } else { 
            media = soma / count;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture);
            }
        }
    }
}
