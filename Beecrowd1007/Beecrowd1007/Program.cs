// Sexto exercício resolvido por João Paulo Bezerra Oliveira
// Curso: C# primeiros passos: Lógica de Programação e Algoritmos - Udemy
// Curitiba, 28 de julho de 2023

using System;

namespace Beecrowd1007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            int B = 0;
            int C = 0;
            int D = 0;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            int DIFERENCA = 0;

            DIFERENCA= (A * B) - (C * D);

            Console.WriteLine("DIFERENCA = " + DIFERENCA);

        }
    }
}