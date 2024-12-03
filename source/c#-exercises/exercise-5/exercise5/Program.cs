using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace exercise5 {
    internal class Program {
        static void Main(string[] args) {
            string[] vet = (Console.ReadLine().Split(' '));
            int a = int.Parse(vet[0]);
            int b = int.Parse(vet[1]);
            int c = int.Parse(vet[2]);

            if (a < b && a < c) {
                Console.WriteLine($"MENOR = {a}");
            } if (b < a && b < c) {
                Console.WriteLine($"MENOR = {b}");
            } else {
                Console.WriteLine($"MENOR = {c}");
            }
        }

    }
}

