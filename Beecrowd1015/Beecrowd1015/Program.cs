// Décimo sétimo exercício resolvido por João Paulo Bezerra Oliveira
// Curso: C# primeiros passos: Lógica de Programação e Algoritmos - Udemy
// Curitiba, 1 de agosto de 2023

using System;

namespace Beecrowd1015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = 0.0;
            double y1 = 0.0;

            string[] vet1 = Console.ReadLine().Split(' ');

            x1 = double.Parse(vet1[0]);
            y1 = double.Parse(vet1[1]);

            double x2 = 0.0;
            double y2 = 0.0;

            string[] vet2 = Console.ReadLine().Split(' ');

            x2 = double.Parse(vet2[0]);
            y2 = double.Parse(vet2[1]);

            double calcDistancia = 0.0;

            calcDistancia = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

            Console.WriteLine(calcDistancia.ToString("F4"));

        }
    }
}