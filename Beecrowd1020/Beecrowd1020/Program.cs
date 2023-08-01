// Vigésimo exercício resolvido por João Paulo Bezerra Oliveira
// Curso: C# primeiros passos: Lógica de Programação e Algoritmos - Udemy
// Curitiba, 1 de agosto de 2023

using System;

namespace Beecrowd1020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;

            idade = int.Parse(Console.ReadLine());

            int calcAnos = 0;

            calcAnos = idade / 365;

            int calcMeses = 0;

            calcMeses = (idade % 365) / 30;

            int calcDias = (idade % 365) % 30;

            Console.WriteLine(calcAnos + " ano(s)");
            Console.WriteLine(calcMeses + " mes(es)");
            Console.WriteLine(calcDias + " dia(s)");

        }
    }
}