// Décimo terceiro exercício resolvido por João Paulo Bezerra Oliveira
// Curso: C# primeiros passos: Lógica de Programação e Algoritmos - Udemy
// Curitiba, 28 de julho de 2023

using System;

namespace Beecrowd1006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = 0.0;
            double B = 0.0;
            double C = 0.0;

            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());

            double calc1 = 0.0;

            calc1 = ((A * 2.0) + (B * 3.0) + (C * 5.0)) / 10.0;

            Console.WriteLine("MEDIA = " + calc1.ToString("F1"));

        }
    }
}