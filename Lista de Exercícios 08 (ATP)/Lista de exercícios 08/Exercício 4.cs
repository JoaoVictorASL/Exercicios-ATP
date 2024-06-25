using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavra;

            Console.Write("\nInforme uma palavra: ");
            palavra = Console.ReadLine();

            Console.WriteLine("Escrita de trás-pra-frente: \n");
            for (int i = palavra.Length - 1;  i >= 0; i--)
            {
                Console.Write(palavra[i]);
            }

            Console.ReadLine();
        }
    }
}
