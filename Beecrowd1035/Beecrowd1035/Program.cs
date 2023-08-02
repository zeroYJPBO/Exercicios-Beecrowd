// Vigésimo primeiro exercício resolvido por João Paulo Bezerra Oliveira
// Curso: C# primeiros passos: Lógica de Programação e Algoritmos - Udemy
// Curitiba, 2 de agosto de 2023

using System;

namespace Beecrowd1035
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            int B = 0;
            int C = 0;
            int D = 0;

            string[] vetA = Console.ReadLine().Split(' ');

            A = int.Parse(vetA[0]);
            B = int.Parse(vetA[1]);
            C = int.Parse(vetA[2]);
            D = int.Parse(vetA[3]);

            if(B > C && D > A && (C + D) > (A + B) && C > 0 && D > 0 && A % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }

        }
    }
}