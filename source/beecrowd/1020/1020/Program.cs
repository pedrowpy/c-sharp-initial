using System;

namespace beecrowd1020 {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int anos = n / 365;
            int resto = n % 365;
            int meses = resto / 30;
            int dias = resto % 30;

            Console.WriteLine($"{anos} ano(s)");
            Console.WriteLine($"{meses} mes(es)");
            Console.WriteLine($"{dias} dia(s)");
        }
    }
}