using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, j, fat;
            double soma;

            soma = 1;
            j = 1;

            Console.WriteLine("Informe um valor:");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                fat = 1;

                for (j = i; j >= 1; j--)
                {
                    fat = fat * j;
                }

                soma = soma + (1.0 / fat);
            }

            Console.WriteLine("O valor da soma S:" + soma);
            Console.ReadLine();
        }
    }
}
