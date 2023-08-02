// Vigésimo terceiro exercício resolvido por João Paulo Bezerra Oliveira
// Curso: C# primeiros passos: Lógica de Programação e Algoritmos - Udemy
// Curitiba, 2 de agosto de 2023

using System;

namespace Beecrowd1044
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            int B = 0;

            string[] vet1 = Console.ReadLine().Split(' ');

            A = int.Parse(vet1[0]);
            B = int.Parse(vet1[1]);

            if(A % B == 0 || B % A == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

        }
    }
}