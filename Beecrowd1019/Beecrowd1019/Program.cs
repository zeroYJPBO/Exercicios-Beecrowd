// Décimo oitavo exercício resolvido por João Paulo Bezerra Oliveira
// Curso: C# primeiros passos: Lógica de Programação e Algoritmos - Udemy
// Curitiba, 1 de agosto de 2023

using System;

namespace Beecrowd1019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            int segundos = 0;
            int minutos = 0;
            int horas = 0;

            N = int.Parse(Console.ReadLine());

            segundos = N % 60;

            minutos = (N / 60) % 60;

            horas = N / 3600;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);

            Console.ReadLine();
        }
    }
}