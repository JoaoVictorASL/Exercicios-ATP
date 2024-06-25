using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_3
{
    internal class Program
    {
        static int Mmc(int a, int b)
        {
            return (a * b) / Mdc(a, b);
        }

        static int Mdc(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static int Mdc(int a, int b, int c)
        {
            return Mdc(Mdc(a, b), c);
        }

        static void Main(string[] args)
        {
            int option;
            do
            {
                Console.WriteLine("Menu de Opções:");
                Console.WriteLine("1) Calcular MMC");
                Console.WriteLine("2) Calcular MDC");
                Console.WriteLine("3) Sair do programa");
                Console.Write("Escolha uma opção: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("Digite o primeiro número: ");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        int num2 = int.Parse(Console.ReadLine());
                        int mmc = Mmc(num1, num2);
                        Console.WriteLine($"O MMC de {num1} e {num2} é: {mmc}");
                        break;

                    case 2:
                        Console.Write("Digite o primeiro número: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        num2 = int.Parse(Console.ReadLine());
                        Console.Write("Digite o terceiro número: ");
                        int num3 = int.Parse(Console.ReadLine());
                        int mdc = Mdc(num1, num2, num3);
                        Console.WriteLine($"O MDC de {num1}, {num2} e {num3} é: {mdc}");
                        break;

                    case 3:
                        Console.WriteLine("Saindo do programa...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }

                Console.WriteLine();
            } while (option != 3);
        }
    }
}
