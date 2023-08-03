// Trigésimo exercício resolvido por João Paulo Bezerra Oliveira
// Curso: C# primeiros passos: Lógica de Programação e Algoritmos - Udemy
// Curitiba, 3 de agosto de 2023

using System;

namespace Beecrowd1134
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;

            valor = int.Parse(Console.ReadLine());

            int somaAlcool = 0;
            int somaGasolina = 0;
            int somaDiesel = 0;

            while(valor != 4) { 
                if(valor == 1)
                {
                    somaAlcool = somaAlcool + 1;
                }

                else if(valor == 2)
                {
                    somaGasolina = somaGasolina + 1;
                }

                else if(valor == 3)
                {
                    somaDiesel = somaDiesel + 1;
                }

                valor = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + somaAlcool);
            Console.WriteLine("Gasolina: " + somaGasolina);
            Console.WriteLine("Diesel: " + somaDiesel);

        }
    }
}