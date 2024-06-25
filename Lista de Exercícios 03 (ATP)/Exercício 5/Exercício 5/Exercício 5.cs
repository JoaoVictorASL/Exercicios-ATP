using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao, meses, feriasint;
            double salario, ferias, decterc;

            opcao = 0;

            while (opcao != 4) {

                Console.WriteLine("Menu de Opções:");
                Console.WriteLine();
                Console.WriteLine("1- Novo Salário");
                Console.WriteLine("2- Férias");
                Console.WriteLine("3- Décimo Terceiro");
                Console.WriteLine("4- Sair");
                Console.WriteLine();
                opcao = int.Parse(Console.ReadLine());

                if (opcao < 1 || opcao > 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Opção Inválida! Tente Novamente:");
                    Console.WriteLine();
                }

                else if (opcao == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Informe seu Sálario em R$: ");
                    Console.WriteLine();
                    salario = double.Parse(Console.ReadLine());

                    if (salario <= 999.99)
                        salario *= 1.15;

                    else if (salario >= 1000 && salario <= 2000)
                        salario *= 1.10;

                    else if (salario > 2000)
                        salario *= 1.05;

                    Console.WriteLine();
                    Console.WriteLine($"Novo salário: R$ {salario}");
                    Console.WriteLine();
                }

                else if (opcao == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("Informe seu Sálario em R$: ");
                    Console.WriteLine();
                    salario = double.Parse(Console.ReadLine());

                    ferias = salario + salario / 3;

                    feriasint = (int) ferias;

                    Console.WriteLine();
                    Console.WriteLine($"Valor de suas Férias: R$ {feriasint}");
                    Console.WriteLine();
                }

                else if (opcao == 3)
                {
                    while (true)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Informe o seu Sálario em R$: ");
                        Console.WriteLine();
                        salario = double.Parse(Console.ReadLine());

                        Console.WriteLine();
                        Console.WriteLine("Informe o número de meses de trabalho na Empresa: ");
                        Console.WriteLine();
                        meses = int.Parse(Console.ReadLine());

                        decterc = salario * meses / 12;

                        if (meses <= 12 && meses >= 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Valor do Décimo Terceiro: R$ {decterc}");
                            Console.WriteLine();

                        break;

                        }

                        else
                            Console.WriteLine();
                            Console.WriteLine("Número de meses inválido! Tente Novamente:");
                            Console.WriteLine();
         
                    }


                }



            }
        }
    }
}
