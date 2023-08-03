// Trigésimo segundo exercício resolvido por João Paulo Bezerra Oliveira
// Curso: C# primeiros passos: Lógica de Programação e Algoritmos - Udemy
// Curitiba, 3 de agosto de 2023

using System;

namespace Beecrowd1159
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = 0;

            X = int.Parse(Console.ReadLine());

            while (X != 0)
            {

                if (X % 2 == 0)
                {
                    X = X + (X + 2) + (X + 4) + (X + 6) + (X + 8);
                    Console.WriteLine(X);
                }
                else
                {
                    X = (X + 1) + (X + 3) + (X + 5) + (X + 7) + (X + 9);
                    Console.WriteLine(X);
                }

                X = int.Parse(Console.ReadLine());
            }
        }
    }
}