// Décimo exercício resolvido por João Paulo Bezerra Oliveira
// Curso: C# primeiros passos: Lógica de Programação e Algoritmos - Udemy
// Curitiba, 28 de julho de 2023

using System;

namespace Beecrowd1016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distancia = 0;

            distancia = int.Parse(Console.ReadLine());

            int calc1 = 0;

            calc1 = distancia * 2;

            Console.WriteLine(calc1 + " minutos");

        }
    }
}