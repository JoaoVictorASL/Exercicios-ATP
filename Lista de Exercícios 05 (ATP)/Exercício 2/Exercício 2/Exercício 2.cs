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
            int digt, i, j, num, cont;

            cont = 0;

            Console.WriteLine("Informe quantos digitos terá o número: ");
            digt = int.Parse(Console.ReadLine());

            int[] vetor = new int[digt];

            for (i = 0; i < digt; i++)
            {
                Console.WriteLine("Informe o digito: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0, j = vetor.Length - 1; i < (vetor.Length/2); i++, j--)
            {
                if (vetor[i] == vetor [j])
                {
                    cont++;
                }
            }

            if (cont == vetor.Length/2)
            {
                Console.WriteLine("É Palíndromo");
            }
            else
            {
                Console.WriteLine("Não é Palíndromo");

            }

            Console.ReadLine();

        }
    }
}
    