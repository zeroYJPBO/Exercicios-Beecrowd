// Segundo exercício resolvido por João Paulo Bezerra Oliveira
// Curso: C# primeiros passos: Lógica de Programação e Algoritmos - Udemy
// Curitiba, 28 de julho de 2023

using System;

namespace Beecrowd1001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            int B = 0;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            int X = 0;

            X = A + B;

            Console.WriteLine("X = " + X);
        }
    }
}