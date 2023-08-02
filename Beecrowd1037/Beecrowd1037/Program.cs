// Vigésimo quinto exercício resolvido por João Paulo Bezerra Oliveira
// Curso: C# primeiros passos: Lógica de Programação e Algoritmos - Udemy
// Curitiba, 2 de agosto de 2023

using System;

namespace Beecrowd1037
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = 0.0;

            num = double.Parse(Console.ReadLine());

            if(num >= 0.0 && num <= 25.00)
            {
                Console.WriteLine("Intervalo [0,25]");
            }

            else if(num > 25.00 && num <= 50.00)
            {
                Console.WriteLine("Intervalo (25,50]");
            }

            else if(num > 50.00 && num <= 75.00)
            {
                Console.WriteLine("Intervalo (50,75]");
            }

            else if(num > 75.00 && num <= 100.00)
            {
                Console.WriteLine("Intervalo (75,100]");
            }

            else
            {
                Console.WriteLine("Fora de intervalo");
            }

        }
    }
}