using System;
using System.Globalization;
using System.Xml;

namespace beecrowd1019 {
    internal class Program {
        static void Main(string[] args) {
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(N);

            int resto = N;

            int nota = 100;
            int quociente = resto / nota;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % nota;

            nota = 50;
            quociente = resto / nota;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % nota;

            nota = 20;
            quociente = resto / nota;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % nota;

            nota = 10;
            quociente = resto / nota;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % nota;

            nota = 5;
            quociente = resto / nota;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % nota;

            nota = 2;
            quociente = resto / nota;
            Console.WriteLine($"{quociente} nota(s) de R$ {nota},00");
            resto = resto % nota;

            Console.WriteLine($"{resto} nota(s) de R$ 1,00");
        }
    }
}