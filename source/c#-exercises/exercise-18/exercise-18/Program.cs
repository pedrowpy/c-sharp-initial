using System;

namespace exercise18
{
    internal class Program {
        static void Main(string[] args) {
            int M, N;
            int[,] mat;
            string[] s = Console.ReadLine().Split(' ');
            M = int.Parse(s[0]);
            N = int.Parse(s[1]);

            // M linhas, N colunas
            mat = new int[M, N];

            for (int i = 0; i < M; i++) {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            int[] vet = new int[M];
            for (int i = 0; i < M; i++) {
                int soma = 0;
                for (int j = 0; j < N; j++) {
                    // Soma de todos elementos das linhas
                    soma += mat[i, j];
                }
                vet[i] = soma;
            }

            for (int i = 0; i < M; ++i) {
                Console.WriteLine($"{vet[i]}");
            }
        }
    }
}