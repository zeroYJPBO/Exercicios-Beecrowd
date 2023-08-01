// Décimo sexto exercício resolvido por João Paulo Bezerra Oliveira
// Curso: C# primeiros passos: Lógica de Programação e Algoritmos - Udemy
// Curitiba, 1 de agosto de 2023

using System;

namespace Beecrowd1012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = 0.0;
            double B = 0.0;
            double C = 0.0;

            string[] vet1 = Console.ReadLine().Split(' ');

            A = double.Parse(vet1[0]);
            B = double.Parse(vet1[1]);
            C = double.Parse(vet1[2]);

            double calcTrianguloR = 0.0;
            double calcCirculo = 0.0;
            double calcTrapezio = 0.0;
            double calcQuadrado = 0.0;
            double calcRetangulo = 0.0;

            calcTrianguloR = (A * C) / 2;

            double pi = 3.14159;

            calcCirculo = pi * Math.Pow(C, 2.0);

            calcTrapezio = ((A + B) * C) / 2.0;

            calcQuadrado = Math.Pow(B, 2.0);

            calcRetangulo = A * B;

            Console.WriteLine("TRIANGULO: " + calcTrianguloR.ToString("F3"));
            Console.WriteLine("CIRCULO: " + calcCirculo.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + calcTrapezio.ToString("F3"));
            Console.WriteLine("QUADRADO: " + calcQuadrado.ToString("F3"));
            Console.WriteLine("RETANGULO: " + calcRetangulo.ToString("F3"));


        }
    }
}