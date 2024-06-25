using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase, fraseMenor, fraseCripto = "";
            int i;

            Console.WriteLine("Informe uma frase:");
            frase = Console.ReadLine();

            fraseMenor = frase.ToLower();
            for(i = 0; i < fraseMenor.Length; i++)
            {
                if (fraseMenor[i] == 'a' || fraseMenor[i] == 'e' || fraseMenor[i] == 'i' || fraseMenor[i] == 'o' || fraseMenor[i] == 'u')
                {
                    fraseCripto += '*';
                }

                else
                    fraseCripto += fraseMenor[i];

            }

            Console.WriteLine("\nFrase Criptografada:");
            Console.WriteLine(fraseCripto);
            Console.ReadLine();
        }
    }
}
