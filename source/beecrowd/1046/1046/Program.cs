using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace beecrowd1044 {
    internal class Program {
        static void Main(string[] args) {
            string[] vet = Console.ReadLine().Split(' ');

            if (vet.Length == 2 &&
            int.TryParse(vet[0], out int inicio) &&
            int.TryParse(vet[1], out int final)) {

                int duracao;
                if (inicio < final) {
                    duracao = final - inicio;
                } else {
                    duracao = 24 - inicio + final;
                }

                Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");

            }
        }
    }
}
