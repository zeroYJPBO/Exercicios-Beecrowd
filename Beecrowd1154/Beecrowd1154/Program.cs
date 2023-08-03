// Trigésimo primeiro exercício resolvido por João Paulo Bezerra Oliveira
// Curso: C# primeiros passos: Lógica de Programação e Algoritmos - Udemy
// Curitiba, 3 de agosto de 2023

using System;

namespace Beecrowd1154
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;

            idade = int.Parse(Console.ReadLine());

            double soma = 0.0;

            double i = 0.0;

            while(idade >= 0)
            {
                soma = soma + idade;
                i = i + 1.0;
                idade = int.Parse(Console.ReadLine());
            }

            double calc1 = 0.0;

            calc1 = soma / i;

            Console.WriteLine(calc1.ToString("F2"));
        }
    }
}