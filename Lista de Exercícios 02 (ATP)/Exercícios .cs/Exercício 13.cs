using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ano;
            string resultado;

            Console.WriteLine("Informe um ano qualquer:");
            ano = int.Parse(Console.ReadLine());

            resultado = (ano % 400 == 0 || (ano % 4 == 0 && ano % 100 != 0)) ? "é bissexto" : "não é bissexto";
            Console.WriteLine($"O ano {ano} {resultado}.");

            Console.ReadLine();
        }
    }
}
