// Nono exercício resolvido por João Paulo Bezerra Oliveira
// Curso: C# primeiros passos: Lógica de Programação e Algoritmos - Udemy
// Curitiba, 28 de julho de 2023

using System;

namespace Beecrowd1014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = 0;

            float Y = 0f;

            X = int.Parse(Console.ReadLine());

            Y = float.Parse(Console.ReadLine());

            float calc1 = 0f;

            calc1 = X / Y;

            Console.WriteLine(calc1.ToString("F3") + " km/l");

        }
    }
}