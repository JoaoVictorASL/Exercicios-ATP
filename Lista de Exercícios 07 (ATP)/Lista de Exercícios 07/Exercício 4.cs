using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_4
{
    class Program
    {
        static double Medias(double num1, double num2, double num3, char opc)
        {
            double Media = double.MinValue;
            if(opc == 'A')
            {
                Media = (num1 + num2 + num3) / 3;
                return Media;
            }

            else if (opc == 'P')
            {
                Media = ((num1 * 5) + (num2 * 3) + (num3 * 2)) / 10;
                return Media;
            }

            else
            {
                return Media;
            }
        }
        static void Main(string[] args)
        {
            double n1, n2, n3, result;
            char opc;

            Console.WriteLine("Digite um valor: ");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o segundo valor: ");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o terceiro valor: ");
            n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite 'A' para calcular a média Aritimética dos valores ou 'P' para calcular a média Ponderada: ");
            opc = char.Parse(Console.ReadLine());

            result = Medias(n1, n2, n3, opc);

            if (result == double.MinValue)
                Console.WriteLine("\nOpção Inválida!");

            else
                Console.WriteLine("\nResultado: " + result);

            Console.ReadLine();
        }
    }
}
