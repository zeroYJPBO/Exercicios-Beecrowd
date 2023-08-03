// Trigésimo terceiro exercício resolvido por João Paulo Bezerra Oliveira
// Curso: C# primeiros passos: Lógica de Programação e Algoritmos - Udemy
// Curitiba, 3 de agosto de 2023

using System;

namespace Beecrowd1118
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = 1;

            while (X == 1)
            {

                double nota1 = 0.0;

                nota1 = double.Parse(Console.ReadLine());

                while (nota1 < 0.0 || nota1 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    nota1 = double.Parse(Console.ReadLine());
                }

                double nota2 = 0.0;

                nota2 = double.Parse(Console.ReadLine());

                while (nota2 < 0.0 || nota2 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    nota2 = double.Parse(Console.ReadLine());
                }

                double media = 0.0;

                media = (nota1 + nota2) / 2.0;

                Console.WriteLine("media = " + media.ToString("F2"));

                Console.WriteLine("novo calculo (1-sim 2-nao)");

                X = int.Parse(Console.ReadLine());

                while(X < 1 || X > 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");

                    X = int.Parse(Console.ReadLine());

                }

            }

        }


    }
}