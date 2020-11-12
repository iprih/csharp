using System;
using System.Globalization;

namespace condicional1
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, soma;

            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = nota1 + nota2;

            Console.WriteLine("nota final: " + soma.ToString("F1", CultureInfo.InvariantCulture));//lembrete de "F1": formata para 1 casa decimal

            if (soma < 60.0)
            {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
