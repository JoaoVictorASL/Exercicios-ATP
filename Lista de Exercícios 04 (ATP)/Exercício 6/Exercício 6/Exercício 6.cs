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
            double C, F, K;
            int opcao;

            do {
                Console.WriteLine("  Menu  ");
                Console.WriteLine();
                Console.WriteLine("1. Converter de Celsius para Fahrenheit");
                Console.WriteLine("2. Converter de Celsius para Kelvin");
                Console.WriteLine("3. Converter de Fahrenheit para Celsius");
                Console.WriteLine("4. Converter de Fahrenheit para Kelvin");
                Console.WriteLine("5. Converter de Kelvin para Celsius");
                Console.WriteLine("6. Converter de Kelvin para Fahrenheit");
                Console.WriteLine("7. Sair");
                Console.WriteLine();
                opcao = int.Parse(Console.ReadLine()); 

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Informe uma temperatura em Graus Celsius");
                        C = double.Parse(Console.ReadLine());
                        F = C * 1.8 + 32;
                        Console.WriteLine();
                        Console.WriteLine("Convertida em Fahrenheit: " + F);
                        Console.WriteLine();
                    break;

                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Informe uma temperatura em Graus Celsius");
                        C = double.Parse(Console.ReadLine());
                        K = C + 273;
                        Console.WriteLine();
                        Console.WriteLine("Convertida em Kelvin: " + K);
                        Console.WriteLine();
                    break;

                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Informe uma temperatura em Fahrenheit");
                        F = double.Parse(Console.ReadLine());
                        C = (F - 32) / 1.8;
                        Console.WriteLine();
                        Console.WriteLine("Convertida em Graus Celsius: " + C);
                        Console.WriteLine();
                    break;

                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("Informe uma temperatura em Fahrenheit");
                        F = double.Parse(Console.ReadLine());
                        K = (F + 459.67) * 5 / 9;
                        Console.WriteLine();
                        Console.WriteLine("Convertida em Fahrenheit: " + K);
                        Console.WriteLine();
                    break;

                    case 5:
                        Console.WriteLine();
                        Console.WriteLine("Informe uma temperatura em Kelvin");
                        K = double.Parse(Console.ReadLine());
                        C = K - 273;
                        Console.WriteLine();
                        Console.WriteLine("Convertida em Graus Celsius: " + C);
                        Console.WriteLine();
                    break;

                    case 6:
                        Console.WriteLine();
                        Console.WriteLine("Informe uma temperatura em Kelvin");
                        K = double.Parse(Console.ReadLine());
                        F = 1.8 * (K - 273) + 32;
                        Console.WriteLine();
                        Console.WriteLine("Convertida em Fahrenheit: " + F);
                        Console.WriteLine();
                    break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Opação Inválida!");
                        Console.WriteLine();
                    break;
                }
            } while (opcao != 7);    

        }
    }
}
