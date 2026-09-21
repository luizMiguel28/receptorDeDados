
using System;

namespace MiniPrograma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CALCULADORA DE MÉDIA ===");

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a primeira nota: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 + nota2) / 2;

            Console.WriteLine();
            Console.WriteLine("Aluno: " + nome);
            Console.WriteLine("Sua média é: " + media);
        }
    }
}
