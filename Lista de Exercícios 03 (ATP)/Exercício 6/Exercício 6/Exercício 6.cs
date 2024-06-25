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
            double salario, somasalario, maxsalario, cont5000, cont15;
            int estudo, somaestudo, habitantes, cont;
            char opcao;

           cont15 = 0;
            cont5000 = 0;   
            cont = 1;
            habitantes = 0;
            somasalario = 0;
            maxsalario = 0;
            somaestudo = 0;


            Console.WriteLine("Deseja informar os dados de um habitante?");
            Console.WriteLine();
            Console.WriteLine("S: Sim, N: Não");
            opcao = char.Parse(Console.ReadLine());

            while (opcao == 'S' || opcao == 's')
            {
                habitantes++;
                cont++;

                Console.WriteLine();
                Console.WriteLine("Informe o salário do habitante:");
                Console.WriteLine();
                salario = double.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Informe a quantidade de anos de estudo do habitante:");
                Console.WriteLine();
                estudo = int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine($"Deseja informar os dados de um {cont}º habitante?");
                Console.WriteLine();
                Console.WriteLine("S: Sim, N: Não");
                opcao = char.Parse(Console.ReadLine());

                if (salario <= 5000)
                    cont5000++;

                if (estudo >= 15)
                    cont15++;


                if (salario > maxsalario)
                    maxsalario = salario;

                somasalario += salario;
                somaestudo += estudo;
            }


            Console.WriteLine();
            Console.WriteLine("Média do salário da população: " + somasalario / habitantes);

            Console.WriteLine();
            Console.WriteLine("Média de anos de estudo da população: " + somaestudo / habitantes);

            Console.WriteLine();
            Console.WriteLine("Maior salário: " + maxsalario);

            Console.WriteLine();
            Console.WriteLine("Percentual de pessoas com salário até R$5000,00: " + cont5000 * 100 / habitantes);

            Console.WriteLine();
            Console.WriteLine("Percentual de pessoas com 15 ou mais anos de estudo: " + cont15 * 100 / habitantes);

            Console.ReadLine(); 


        }
    }
}
