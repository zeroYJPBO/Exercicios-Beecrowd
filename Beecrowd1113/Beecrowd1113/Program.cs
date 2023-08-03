// Vigésimo sétimo exercício resolvido por João Paulo Bezerra Oliveira
// Curso: C# primeiros passos: Lógica de Programação e Algoritmos - Udemy
// Curitiba, 3 de agosto de 2023

using System;

namespace Beecrowd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = 0;
            int Y = 0;

            string[] vet1 = Console.ReadLine().Split(' ');

            X = int.Parse(vet1[0]);
            Y = int.Parse(vet1[1]);

            while(X != Y)
            {
                if(X > Y)
                {
                    Console.WriteLine("Decrescente");
                }
                else
                {
                    Console.WriteLine("Crescente");
                }

                string[] vet2 = Console.ReadLine().Split(' ');

                X = int.Parse(vet2[0]);
                Y = int.Parse(vet2[1]);
            }
        }
    }
}