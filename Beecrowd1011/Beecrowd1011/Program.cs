// Décimo quinto exercício resolvido por João Paulo Bezerra Oliveira
// Curso: C# primeiros passos: Lógica de Programação e Algoritmos - Udemy
// Curitiba, 1 de agosto de 2023

using System;

namespace Exercicio1011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double R = 0.0;

            R = double.Parse(Console.ReadLine());

            double pi = 3.14159;

            double calc1 = 0.0;

            calc1 = (4.0 / 3.0) * pi * Math.Pow(R, 3.0);

            Console.WriteLine("VOLUME = " + calc1.ToString("F3"));



        }
    }
}