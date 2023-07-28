// Oitavo exercício resolvido por João Paulo Bezerra Oliveira
// Curso: C# primeiros passos: Lógica de Programação e Algoritmos - Udemy
// Curitiba, 28 de julho de 2023

using System;

namespace Beecrowd1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] v1 = Console.ReadLine().Split(' ');

            int codPeca1 = 0;
            int nPeca1 = 0;
            double valorUni = 0.0;

            codPeca1 = int.Parse(v1[0]);
            nPeca1 = int.Parse(v1[1]);
            valorUni = double.Parse(v1[2]);

            string[] v2 = Console.ReadLine().Split(' ');

            int codPeca2 = 0;
            int nPeca2 = 0;
            double valorUni2 = 0.0;

            codPeca2 = int.Parse(v2[0]);
            nPeca2 = int.Parse(v2[1]);
            valorUni2 = double.Parse(v2[2]);

            double calc1 = 0.0;

            calc1 = (nPeca1 * valorUni) + (nPeca2 * valorUni2);

            Console.WriteLine("VALOR A PAGAR: R$ " + calc1.ToString("F2"));

        }
    }
}