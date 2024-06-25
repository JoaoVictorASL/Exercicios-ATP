using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeiro, segundo, n, num, proximo, count;

            count = 2;
            primeiro = 0;
            segundo = 1;

            Console.Write("Digite o número de elementos da sequência de Fibonacci que deseja imprimir: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Os { n } primeiros números da sequência de Fibonacci são:  ");
            Console.WriteLine();


            Console.Write(primeiro + " " + segundo + " ");

            while (n > count)
            {
                count++;

                proximo = primeiro + segundo;
                Console.Write(proximo + " ");

                primeiro = segundo;
                segundo = proximo;

            }

            Console.ReadLine();
        }
    }
}
