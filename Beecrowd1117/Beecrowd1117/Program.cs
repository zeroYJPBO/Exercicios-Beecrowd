// Vigésimo nono exercício resolvido por João Paulo Bezerra Oliveira
// Curso: C# primeiros passos: Lógica de Programação e Algoritmos - Udemy
// Curitiba, 3 de agosto de 2023

using System;

namespace Beecrowd1117
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1 = 0.0;

            nota1 = double.Parse(Console.ReadLine());

            while(nota1 < 0.0 || nota1 > 10.0)
            {
                Console.WriteLine("nota invalida");

                nota1 = double.Parse(Console.ReadLine());
            }

            double nota2 = 0.0;

            nota2 = double.Parse(Console.ReadLine());

            while(nota2 < 0.0 || nota2 > 10.0)
            {
                Console.WriteLine("nota invalida");

                nota2 = double.Parse(Console.ReadLine());
            }

            double media = 0.0;

            media = (nota1 + nota2) / 2.0;

            Console.WriteLine("media = " + media.ToString("F2"));
        }
    }
}