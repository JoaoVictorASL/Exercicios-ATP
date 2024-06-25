using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numx, numy;

            Console.WriteLine("Informe um número ímpar:");
            numx = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe um número ímpar maior que o anterior:");
            numy = int.Parse(Console.ReadLine());

            if (numx > numy || numx % 2 == 0 || numx % 2 == 0)
            {

                Console.WriteLine("Número Ínválido!");
            }
            else
            {
                Console.Write("Os valores ímpares entre esse dois números são:");
                while (numx <= numy)
                {
                    Console.Write(numx + " ");
                    numx += 2;
                }
            }
            Console.ReadLine();
        }

    }
}
