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
            double indice, somaind, indmax, indmed;
            int dia, cont;

            dia = 0;
            cont = 0;
            indmax = -1;
            somaind = 0;
                
            while (cont < 31)
            {
                cont++;
                Console.WriteLine($"Informe o índice pluviométrico do {cont}º dia: ");
                indice = double.Parse(Console.ReadLine());
                somaind = somaind + indice;
                
                if (indice > indmax)
                {
                    indmax = indice;
                    dia = cont;
                }
            }

            indmed = somaind / 31;

            Console.WriteLine("O índice pluviométrico médio é:" + indmed);
            Console.WriteLine("O índice pluviométrico máximo foi de:" + indmax);
            Console.WriteLine("O maior índice foi no dia:" + dia);

            Console.ReadLine(); 

        }
    }
}
