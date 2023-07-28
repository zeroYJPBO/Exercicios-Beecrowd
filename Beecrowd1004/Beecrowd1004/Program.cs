// Quinto exercício resolvido por João Paulo Bezerra Oliveira
// Curso: C# primeiros passos: Lógica de Programação e Algoritmos - Udemy
// Curitiba, 28 de julho de 2023

using System;

namespace Beecrowd1004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 0;
            int valor2 = 0;

            valor1 = int.Parse(Console.ReadLine());
            valor2 = int.Parse(Console.ReadLine());

            int PROD = 0;

            PROD = valor1 * valor2;

            Console.WriteLine("PROD = " + PROD);

        }
    }
}