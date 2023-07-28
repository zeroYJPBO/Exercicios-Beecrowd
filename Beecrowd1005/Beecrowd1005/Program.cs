// Décimo segundo exercício resolvido por João Paulo Bezerra Oliveira
// Curso: C# primeiros passos: Lógica de Programação e Algoritmos - Udemy
// Curitiba, 28 de julho de 2023

using System;

namespace Beecrowd1005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = 0.0;
            double B = 0.0;

            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());

            double media = 0.0;

            media = ((A * 3.5) + (B * 7.5)) / 11.0;

            Console.WriteLine("MEDIA = " + media.ToString("F5"));

        }
    }
}