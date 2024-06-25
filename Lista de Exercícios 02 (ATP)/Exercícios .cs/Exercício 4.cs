using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, resultsoma, resultsub, resultmult, resultdiv;
            int opcao;

            Console.WriteLine("Escolha uma operação a ser feita:");
            Console.WriteLine("1- Adição");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine("Digite um número");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite outro número");
                num2 = double.Parse(Console.ReadLine());

                resultsoma = num1 + num2;

                Console.WriteLine("O resultado é:" + resultsoma);
                Console.ReadLine();
            }

            else if (opcao == 2)
            {
                Console.WriteLine("Digite um número");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite outro número");
                num2 = double.Parse(Console.ReadLine());

                resultsub = num1 - num2;

                Console.WriteLine("O resultado é:" + resultsub);
                Console.ReadLine();
            }

            else if (opcao == 3)
            {
                Console.WriteLine("Digite um número");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite outro número");
                num2 = double.Parse(Console.ReadLine());

                resultmult = num1 * num2;

                Console.WriteLine("O resultado é:" + resultmult);
                Console.ReadLine();
            }

            else if (opcao == 4)
            {
                Console.WriteLine("Digite um número");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite outro número");
                num2 = double.Parse(Console.ReadLine());

                resultdiv = num1 / num2;

                Console.WriteLine("O resultado é:" + resultdiv);
                Console.ReadLine();
            }
        }
    }
}
