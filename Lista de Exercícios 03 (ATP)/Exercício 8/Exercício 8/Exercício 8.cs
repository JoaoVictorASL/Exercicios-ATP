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
            int primeiro, segundo, n, proximo, count;

            count = 2;
            primeiro = 0;
            segundo = 1;
            proximo = 0;

            Console.Write("Digite um valor: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Todos os elementos da sequência de Fibonacci que são menores que { n }:  ");
            Console.WriteLine();

            if (n <= 1)
                Console.WriteLine($"Não existem elementos Menores que {n} na sequência Fibonacci");

            else
            {
                Console.Write(primeiro + " " + segundo + " ");

                while (primeiro + segun < n)
                {
                    count++;
                    proximo = primeiro + segundo;

                    Console.Write(proximo + " ");

                    primeiro = segundo;
                    segundo = proximo;

                }
            }

            Console.ReadLine();
        }
    }
}
