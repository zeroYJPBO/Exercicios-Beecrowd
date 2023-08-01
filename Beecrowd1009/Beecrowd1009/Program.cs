// Décimo quarto exercício resolvido por João Paulo Bezerra Oliveira
// Curso: C# primeiros passos: Lógica de Programação e Algoritmos - Udemy
// Curitiba, 1 de agosto de 2023

namespace Beecrowd1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salarioFixo = 0.0;
            double totalDeVendas = 0.0;

            nome = Console.ReadLine();

            salarioFixo = double.Parse(Console.ReadLine());

            totalDeVendas = double.Parse(Console.ReadLine());

            double calc1 = 0.0;

            calc1 = totalDeVendas * 0.15;

            double calc2 = 0.0;

            calc2 = calc1 + salarioFixo;

            Console.WriteLine("TOTAL = R$ " + calc2.ToString("F2"));

            Console.ReadLine();
        }
    }
}