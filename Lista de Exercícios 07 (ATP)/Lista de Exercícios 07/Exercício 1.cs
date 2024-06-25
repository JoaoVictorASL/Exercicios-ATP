using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    internal class Program
    {
        static int MenorValor(int a, int b, int c, int d)
        {
            int menor = a;

            if (b < menor)
            {
                menor = b;
            }
            if (c < menor)
            {
                menor = c;
            }
            if (d < menor)
            {
                menor = d;
            }

            return menor;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite quatro números inteiros:");

            Console.Write("Primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Terceiro número: ");
            int num3 = int.Parse(Console.ReadLine());

            Console.Write("Quarto número: ");
            int num4 = int.Parse(Console.ReadLine());

            int menor = MenorValor(num1, num2, num3, num4);
            Console.WriteLine($"O menor valor digitado é: {menor}");
        }
    }
}
