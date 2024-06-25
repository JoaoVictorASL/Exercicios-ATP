using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string String;
            char caractere;

            Console.Write("Digite uma string: ");
            String = Console.ReadLine();

            Console.Write("Digite um caractere: ");
            caractere = char.Parse(Console.ReadLine());

            int count = 0;
            foreach (char c in String)
            {
                if (c == caractere)
                {
                    count++;
                }
            }

            Console.WriteLine($"\nO caractere '{caractere}' aparece {count} vez(es) na string.");
            Console.ReadLine();
        }
    }
}
