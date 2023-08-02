// Vigésimo segundo exercício resolvido por João Paulo Bezerra Oliveira
// Curso: C# primeiros passos: Lógica de Programação e Algoritmos - Udemy
// Curitiba, 2 de agosto de 2023

using System;

namespace Beecrowd1038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo = 0;
            int qtdItem = 0;

            string[] vetVenda = Console.ReadLine().Split(' ');

            codigo = int.Parse(vetVenda[0]);
            qtdItem = int.Parse(vetVenda[1]);

            double calc = 0.0;

            if(codigo == 1)
            {
                calc = 4.0 * qtdItem;
                Console.WriteLine("Total: R$ " + calc.ToString("F2"));
            }

            else if (codigo == 2)
            {
                calc = 4.50 * qtdItem;
                Console.WriteLine("Total: R$ " + calc.ToString("F2"));
            }

            else if (codigo == 3)
            {
                calc = 5.0 * qtdItem;
                Console.WriteLine("Total: R$ " + calc.ToString("F2"));
            }

            else if (codigo == 4)
            {
                calc = 2.0 * qtdItem;
                Console.WriteLine("Total: R$ " + calc.ToString("F2"));
            }

            else if (codigo == 5)
            {
                calc = 1.50 * qtdItem;
                Console.WriteLine("Total: R$ " + calc.ToString("F2"));
            }




        }
    }
}