using System;
using System.Globalization;

namespace CourseIntroduction
{
    internal class Program {
        static void Main(string[] args) {
            //double x = 10.123;
            //Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));

            //int x, y;
            //x = 5;
            //y = 2 * x;

            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //Console.ReadLine();

            //string frase = Console.ReadLine();
            //string x = Console.ReadLine();
            //string y = Console.ReadLine();
            //string z = Console.ReadLine();
            //string s = Console.ReadLine();
            //string s = Console.ReadLine();
            //string[] v = s.Split(' '); // analisar os strings, reconhecidos pelos espaços em branco, armazenando em vetores de string
            //string a1 = v[0];
            //string b2 = v[1];
            //string c3 = v[2];

            //Console.WriteLine("Você digitou: ");
            //Console.WriteLine(frase);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.WriteLine(a1);
            //Console.WriteLine(b2);
            //Console.WriteLine(c3);

            //int n1 = int.Parse(Console.ReadLine());
            //char ch = char.Parse(Console.ReadLine());
            //double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine("Você digitou: ");
            //Console.WriteLine(n1);
            //Console.WriteLine(ch);
            //Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));

            //string[] vet = Console.ReadLine().Split(' ');
            //string nome = vet[0];
            //char sexo = char.Parse(vet[1]);
            //int idade = int.Parse(vet[2]);
            //double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            //Console.WriteLine(nome);
            //Console.WriteLine(sexo);
            //Console.WriteLine(idade);
            //Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));



            Console.WriteLine("Entre com seu nome completo:");
            string fullName = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int bedrooms = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product price:");
            double price = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha)");
            string[] vect = Console.ReadLine().Split(' ');
            string lastName = vect[0];
            int age = int.Parse(vect[1]);
            double height = double.Parse(vect[2], CultureInfo.InvariantCulture);

            Console.WriteLine(fullName);
            Console.WriteLine(bedrooms);
            Console.WriteLine(price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}