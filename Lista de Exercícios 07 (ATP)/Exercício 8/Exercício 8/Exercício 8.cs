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
            double S = 0;
            int cont;

            for(cont = 1; cont <= n; cont++)
            {
                S += (Math.Pow(cont, 2) + 1) / (cont + 3);
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
                Console.Write("\nResultado da expressão: \nS = 2/4 + 5/5 + 10/6... + n²+1 / n+3: " + result.ToString("F2"));
            }

            Console.ReadLine();
        }
    }
}
