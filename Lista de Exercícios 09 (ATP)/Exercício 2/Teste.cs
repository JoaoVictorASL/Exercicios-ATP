using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    internal class Teste
    {
        static void Main(string[] args)
        {
            string dia, mes, ano;

            Console.WriteLine("Data 1: \n");
            Console.Write("Informe o Dia: ");
            dia = Console.ReadLine();
            Console.Write("Informe o Mês: ");
            mes = Console.ReadLine();
            Console.Write("Informe o Ano: ");
            ano = Console.ReadLine();
            Console.WriteLine();

            Data data = new Data(dia, mes, ano);
            Console.WriteLine(data);

            Console.WriteLine("\nData 2: \n");
            Console.Write("Informe o Dia: ");
            dia = Console.ReadLine();
            Console.Write("Informe o Mês: ");
            mes = Console.ReadLine();
            Console.Write("Informe o Ano: ");
            ano = Console.ReadLine();
            Console.WriteLine();

            Data data2 = new Data(dia, mes, ano);
            Console.WriteLine(data2);
            Console.ReadLine();


        }
    }
}
