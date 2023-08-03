// Vigésimo oitavo exercício resolvido por João Paulo Bezerra Oliveira
// Curso: C# primeiros passos: Lógica de Programação e Algoritmos - Udemy
// Curitiba, 3 de agosto de 2023

using System;

namespace Beecrowd1114
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;

            valor = int.Parse(Console.ReadLine());

            while(valor != 2002)
            {
                Console.WriteLine("Senha Invalida");

                valor = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}