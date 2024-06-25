using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string String;

            Console.Write("Digite uma string: ");
            String = Console.ReadLine();

            var resultado = VogaisEConsoantes(String);

            Console.WriteLine($"Número de vogais: {resultado.vogais}");
            Console.WriteLine($"Número de consoantes: {resultado.consoantes}");
        }

        static (int vogais, int consoantes) VogaisEConsoantes(string str)
        {
            string vogais = "aeiouAEIOU";

            int numVogais = str.Count(c => vogais.Contains(c));
            int numConsoantes = str.Count(c => char.IsLetter(c) && !vogais.Contains(c));

            return (numVogais, numConsoantes);
        }
    }
}
