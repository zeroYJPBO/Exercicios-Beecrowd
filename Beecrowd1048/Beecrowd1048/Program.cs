// Vigésimo quarto exercício resolvido por João Paulo Bezerra Oliveira
// Curso: C# primeiros passos: Lógica de Programação e Algoritmos - Udemy
// Curitiba, 2 de agosto de 2023

using System;

namespace Beecrowd1048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario = 0.0;
            salario = double.Parse(Console.ReadLine());

            if (salario >= 0.0 && salario <= 400.00)
            {
                double PercentualAumento = 15;

                double calcReajuste = 0.0;

                calcReajuste = salario * (PercentualAumento / 100);

                double calc2 = 0.0;

                calc2 = salario + calcReajuste;

                Console.WriteLine("Novo salario: " + calc2.ToString("F2"));
                Console.WriteLine("Reajuste ganho: " + calcReajuste.ToString("F2"));
                Console.WriteLine("Em percentual: " + PercentualAumento + " %");

            }

            else if (salario >= 400.01 && salario <= 800.00)
            {
                double PercentualAumento = 12;
                double calcReajuste = 0.0;

                calcReajuste = salario * (PercentualAumento / 100);

                double calc2 = 0.0;

                calc2 = salario + calcReajuste;

                Console.WriteLine("Novo salario: " + calc2.ToString("F2"));
                Console.WriteLine("Reajuste ganho: " + calcReajuste.ToString("F2"));
                Console.WriteLine("Em percentual: " + PercentualAumento + " %");

            }

            else if (salario >= 800.01 && salario <= 1200.00)
            {
                double PercentualAumento = 10;
                double calcReajuste = 0.0;

                calcReajuste = salario * (PercentualAumento / 100);

                double calc2 = 0.0;

                calc2 = salario + calcReajuste;

                Console.WriteLine("Novo salario: " + calc2.ToString("F2"));
                Console.WriteLine("Reajuste ganho: " + calcReajuste.ToString("F2"));
                Console.WriteLine("Em percentual: " + PercentualAumento + " %");

            }

            else if (salario >= 1200.01 && salario <= 2000.00)
            {
                double PercentualAumento = 7;
                double calcReajuste = 0.0;

                calcReajuste = salario * (PercentualAumento / 100);

                double calc2 = 0.0;

                calc2 = salario + calcReajuste;

                Console.WriteLine("Novo salario: " + calc2.ToString("F2"));
                Console.WriteLine("Reajuste ganho: " + calcReajuste.ToString("F2"));
                Console.WriteLine("Em percentual: " + PercentualAumento + " %");

            }

            else if (salario > 2000.00)
            {
                double PercentualAumento = 4;
                double calcReajuste = 0.0;

                calcReajuste = salario * (PercentualAumento / 100);

                double calc2 = 0.0;

                calc2 = salario + calcReajuste;

                Console.WriteLine("Novo salario: " + calc2.ToString("F2"));
                Console.WriteLine("Reajuste ganho: " + calcReajuste.ToString("F2"));
                Console.WriteLine("Em percentual: " + PercentualAumento + " %");

            }



        }
    }
}