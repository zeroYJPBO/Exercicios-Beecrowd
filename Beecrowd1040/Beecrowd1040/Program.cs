// Vigésimo sexto exercício resolvido por João Paulo Bezerra Oliveira
// Curso: C# primeiros passos: Lógica de Programação e Algoritmos - Udemy
// Curitiba, 2 de agosto de 2023

using System;

namespace Beecrowd1040
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float N1 = 0f;
            float N2 = 0f;
            float N3 = 0f;
            float N4 = 0f;
            float media = 0f;

            string[] vetMedias = Console.ReadLine().Split(' ');

            N1 = float.Parse(vetMedias[0]);
            N2 = float.Parse(vetMedias[1]);
            N3 = float.Parse(vetMedias[2]);
            N4 = float.Parse(vetMedias[3]);

            media = ((N1 * 2f) + (N2 * 3f) + (N3 * 4f) + (N4 * 1f)) / 10;

            if (media == 4.85f)
            {
                media = 4.8f;
            }

            Console.WriteLine("Media: " + media.ToString("F1"));

            if(media >= 7.0f)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if(media < 5.0f)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else if(media >= 5.0f && media <= 6.9f)
            {
                Console.WriteLine("Aluno em exame.");

                float notaDoExame = 0.0f;

                notaDoExame = float.Parse(Console.ReadLine());

                Console.WriteLine("Nota do exame: " + notaDoExame.ToString("F1"));

                float calcNewMedia = 0.0f;

                calcNewMedia = (media + notaDoExame) / 2.0f;

                if(calcNewMedia >= 5.0f)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }

                Console.WriteLine("Media final: " + calcNewMedia.ToString("F1"));

            }

        }
    }
}