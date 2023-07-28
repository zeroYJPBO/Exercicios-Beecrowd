// Terceiro exercício resolvido por João Paulo Bezerra Oliveira
// Curso: C# primeiros passos: Lógica de Programação e Algoritmos - Udemy
// Curitiba, 28 de julho de 2023

using System;

namespace Beecrowd1002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio = 0.0;

            raio = double.Parse(Console.ReadLine());

            double π = 3.14159;

            double area = 0.0;

            area = π * Math.Pow(raio, 2.0);

            Console.WriteLine("A=" + area.ToString("F4"));

            Console.ReadLine();
        }
    }
}