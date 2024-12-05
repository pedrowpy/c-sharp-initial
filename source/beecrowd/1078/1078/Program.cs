using System;

namespace beecrowd1078
{
    internal class Program {
        static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine());

            for (int i=1; i<=10; i++) {
                int resultado = i * N;
                Console.WriteLine($"{i} x {N} = {resultado}");
            }
        }
    }
}