using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int alimentacao, transporte, i;
            double m, pagamento;

            for (i = 0; i < 25; i++)
            {
                Console.WriteLine("Informe o valor da Alimentação:");
                Console.WriteLine();
                alimentacao = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o valor do Transporte:");
                Console.WriteLine();
                transporte = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe quantos metros quadrados o pedreiro produziu:");
                Console.WriteLine();
                m = int.Parse(Console.ReadLine());

                if (m < 10)
                    m *= 10;

                else if (m <= 20)
                    m *= 11.5;

                else if (m > 20)
                    m *= 13;

                pagamento = alimentacao + (transporte * 2) + m;

                Console.WriteLine($"O valor a ser pago é de R$ {pagamento}:");
                Console.WriteLine();

            }

            Console.ReadLine();

        }
    }
}
