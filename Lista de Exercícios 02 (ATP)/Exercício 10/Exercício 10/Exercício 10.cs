using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            double valorcm, valorm, valormm, convertidom, convertidocm, convertidomm;

            Console.WriteLine("Escolha uma das seguintes Opções:");
            Console.WriteLine();
            Console.WriteLine("1- Conversão de Centímetros para Metros");
            Console.WriteLine("2- Conversão de Metros para Centímetros");
            Console.WriteLine("3- Conversão de Milímetros para Metros");
            Console.WriteLine("4- Conversão de Metros para Milimetros");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Console.WriteLine("Informe um valor em Centímetros:");
                    valorcm = int.Parse(Console.ReadLine());
                    convertidom = valorcm * 0.01;
                    Console.WriteLine("Convertido em Metros:" + convertidom);
                break;

                case 2:
                    Console.WriteLine("Informe um valor em Metros:");
                    valorm = int.Parse(Console.ReadLine());
                    convertidocm = valorm * 100;
                    Console.WriteLine("Convertido em Centímetros:" + convertidocm);
                break;

                case 3:
                    Console.WriteLine("Informe um valor em Milímetros:");
                    valormm = int.Parse(Console.ReadLine());
                    convertidom = valormm * 0.001;
                    Console.WriteLine("Convertido em Metros:" + convertidom);
                break;

                case 4:
                    Console.WriteLine("Informe um valor em Metros:");
                    valorm = int.Parse(Console.ReadLine());
                    convertidomm = valorm * 1000;
                    Console.WriteLine("Convertido em Milímetros:" + convertidomm);
                break;

                default:
                    Console.WriteLine("Opção Inválida");
                break;
            }
            Console.ReadLine(); 


        }
    }
}
