using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_7
{
    internal class Program
    {
        static int NumPalavras(string frase)
        {
            char space = ' ';
            int codigoAscii = (int) space;
            int cont = 0;

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == space)
                    cont++;
            }
            return cont;
        }
        static void Main(string[] args)
        {
            int cont;
            string frase;

            Console.WriteLine("Digite uma frase: \n");
            frase = Console.ReadLine();

            cont = NumPalavras (frase) + 1;

            Console.WriteLine("\nNúmero de palavras: " + cont);
            Console.ReadLine();
        }
    }
}
