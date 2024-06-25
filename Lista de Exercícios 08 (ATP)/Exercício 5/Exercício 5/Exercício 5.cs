using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Exercício_5
{
    internal class Program
    {
        static bool TestePalíndromo(string palavra)
        {
            int i, j;
            bool teste = true;
            char[] InversaVet = new char[palavra.Length];

            for (i = palavra.Length - 1, j = 0; i >= 0; i--, j++)
            {
                InversaVet[j] = palavra[i];
            }

            string inversa = new string(InversaVet);

            if (inversa != palavra)
                teste = false;

            return teste;
        }
        static void Main(string[] args)
        {
            bool teste;
            string String;

            Console.Write("Informe uma String: ");
            String = Console.ReadLine();

            teste = TestePalíndromo(String);
            if (teste == true)
                Console.WriteLine($"\n{String} é um Palíndromo");

            else
                Console.WriteLine($"\n{String} não é um Palíndromo");

            Console.ReadLine();


        }
    }
}
