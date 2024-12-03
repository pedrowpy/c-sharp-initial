using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace beecrowd1044 {
    internal class Program {
        static void Main(string[] args) {
            string[] vet = Console.ReadLine().Split(' ');

            if (vet.Length == 2 &&
            int.TryParse(vet[0], out int a) &&
            int.TryParse(vet[1], out int b)) {

                if (a % b == 0 || b % a == 0) {
                    Console.WriteLine("Sao Multiplos");
                } else {
                    Console.WriteLine("Nao sao Multiplos");
                }

            }
        }
    }
}
