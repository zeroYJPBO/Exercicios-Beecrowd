// Décimo primeiro exercício resolvido por João Paulo Bezerra Oliveira
// Curso: C# primeiros passos: Lógica de Programação e Algoritmos - Udemy
// Curitiba, 28 de julho de 2023

using System;

namespace Beecrowd1017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempoGasto = 0;
            int velMedia = 0;

            tempoGasto = int.Parse(Console.ReadLine());
            velMedia = int.Parse(Console.ReadLine());

            double calc1 = 0.0;

            calc1 = (tempoGasto * velMedia) / 12.0;

            Console.WriteLine(calc1.ToString("F3"));



        }
    }
}