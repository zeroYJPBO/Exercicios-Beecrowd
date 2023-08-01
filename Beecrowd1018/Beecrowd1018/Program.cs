// Décimo nono exercício resolvido por João Paulo Bezerra Oliveira
// Curso: C# primeiros passos: Lógica de Programação e Algoritmos - Udemy
// Curitiba, 1 de agosto de 2023

using System;

namespace Beecrowd1018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            int calc100 = 0;
            int calc50 = 0;
            int calc20 = 0;
            int calc10 = 0;
            int calc5 = 0;
            int calc2 = 0;
            int calc1 = 0;

            N = int.Parse(Console.ReadLine());

            calc100 = N / 100;

            calc50 = (N % 100) / 50;

            calc20 = ((N % 100) % 50) / 20;

            calc10 = (((N % 100) % 50) % 20) / 10;

            calc5 = ((((N % 100) % 50) % 20) % 10) / 5;

            calc2 = (((((N % 100) % 50) % 20) % 10) % 5) / 2;

            calc1 = ((((((N % 100) % 50) % 20) % 10) % 5) % 2) / 1;


            Console.WriteLine(N);
            Console.WriteLine(calc100 + " nota(s) de R$ 100,00");
            Console.WriteLine(calc50 + " nota(s) de R$ 50,00");
            Console.WriteLine(calc20 + " nota(s) de R$ 20,00");
            Console.WriteLine(calc10 + " nota(s) de R$ 10,00");
            Console.WriteLine(calc5 + " nota(s) de R$ 5,00");
            Console.WriteLine(calc2 + " nota(s) de R$ 2,00");
            Console.WriteLine(calc1 + " nota(s) de R$ 1,00");

        }
    }
}