using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace beecrowd1044 {
    internal class Program {
        static void Main(string[] args) {
            double salarioInicio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double percentual = 0;

            if (salarioInicio >= 0 && salarioInicio <= 400.00) {
                percentual = 15.0;
            } else if (salarioInicio >= 400.01 && salarioInicio <= 800.00) {
                percentual = 12.0;
            } else if (salarioInicio >= 800.01 && salarioInicio <= 1200.00) {
                percentual = 10.0;
            } else if (salarioInicio >= 1200.01 && salarioInicio <= 2000.00) {
                percentual = 7.0;
            } else if (salarioInicio > 2000.00) {
                percentual = 4.0;
            }

            double reajuste = salarioInicio * percentual / 100;
            double novoSalario = salarioInicio + reajuste;

            Console.WriteLine($"Novo salario: {novoSalario.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Em percentual: {percentual} %");
        }
    }
}
