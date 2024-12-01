using System;

namespace beecrowd1003
{
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite o primeiro valor de A");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digie o segundo valor B");
            int B = int.Parse(Console.ReadLine());

            int SOMA = A + B;

            Console.WriteLine($"SOMA = {SOMA}");
        }
    }
}