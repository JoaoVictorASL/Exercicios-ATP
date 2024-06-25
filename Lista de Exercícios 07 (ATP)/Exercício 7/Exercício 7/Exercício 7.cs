using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_7
{
    internal class Program
    {
        static double CalculoS(int n)
        {
            double S;
            int divisor;

            for (divisor = 2, S = 1; divisor <= n; divisor++)
            {
                S += 1.0 / divisor;
            }
            return S;
        }
        static void Main(string[] args)
        {
            double result;
            int valor;

            Console.Write("Informe um valor para 'n' que seja maior do que 0: ");
            valor = int.Parse(Console.ReadLine());

            if (valor <= 0)
                Console.WriteLine("\nValor Inválido!");
            else
            {
                result = CalculoS(valor);
                Console.Write("\nResultado da expressão: S = 1 + 1/2 + 1/3 ... + 1/n: " + result.ToString("F2"));
            }

            Console.ReadLine();
        }
    }
}
