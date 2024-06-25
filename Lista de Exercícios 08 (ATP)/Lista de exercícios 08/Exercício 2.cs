using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string string1, string2;

            Console.Write("Digite a primeira string: ");
            string1 = Console.ReadLine();

            Console.Write("Digite a segunda string: ");
            string2 = Console.ReadLine();

            if (string1.Equals(string2))
            {
                Console.WriteLine("\nstrings iguais");
            }
            else
            {
                if (string1.Length > string2.Length)
                {
                    Console.WriteLine($"\nMaior string: {string1}");
                }
                else if (string2.Length > string1.Length)
                {
                    Console.WriteLine($"\nMaior string: {string2}");
                }
                else
                {
                    Console.WriteLine("\nAs strings têm o mesmo tamanho.");
                }

                string concatenacao = string.Concat(string1, string2);
                Console.WriteLine($"\nConcatenação das strings: {concatenacao}");
            }
        }
    }
}
