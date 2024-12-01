using System;
using System.Net.Http.Headers;
using System.Threading.Channels;

namespace beecrowd1004 
{
    internal class Program {
        static void Main(string[] args) {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int prod = a * b;
            Console.WriteLine($"PROD = {prod}");
        }
    }
}