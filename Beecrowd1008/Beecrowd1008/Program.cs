// Sétimo exercício resolvido por João Paulo Bezerra Oliveira
// Curso: C# primeiros passos: Lógica de Programação e Algoritmos - Udemy
// Curitiba, 28 de julho de 2023

using System;

namespace Beecrowd1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nFuncionario = 0;
            int horasTrabalhadas = 0;
            double valorPorHora = 0.0;

            nFuncionario = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());
            valorPorHora = double.Parse(Console.ReadLine());

            double calc1 = 0.0;

            calc1 = horasTrabalhadas * valorPorHora;

            Console.WriteLine("NUMBER = " + nFuncionario);
            Console.WriteLine("SALARY = U$ " + calc1.ToString("F2"));

        }
    }
}