using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, desconto;
            char opcao;

            do
            {
                Console.WriteLine("Informe o Salário em reais:");
                salario = double.Parse(Console.ReadLine());

                if (salario <= 1412)
                {
                    desconto = salario * 0.075;
                    Console.WriteLine();
                    Console.WriteLine($"O valor do desconto do INSS deste funcionário é de  R${ Math.Round(desconto, 2) }");
                }

                else if (salario >= 1412.01 && salario <= 2666.68)
                {
                    desconto = (1412 * 0.075) + ((salario - 1412.01) * 0.09);
                    Console.WriteLine();
                    Console.WriteLine($"O valor do desconto do INSS deste funcionário é de  R${Math.Round(desconto, 2)}");
                }

                else if (salario >= 2666.69 && salario <= 4000.03)
                {
                    desconto  = (1412 * 0.075) + ((2666.68 - 1412.01) * 0.09) + ((salario - 2666.69) * 0.12);
                    Math.Round(desconto, 2);
                    Console.WriteLine();
                    Console.WriteLine($"O valor do desconto do INSS deste funcionário é de  R${Math.Round(desconto, 2)}");
                }

                else if (salario >= 4000.04 && salario <= 7786.02)
                {
                    desconto = (1412 * 0.075) + ((2666.68 - 1412.01) * 0.09) + ((4000.03 - 2666.69) * 0.12) + ((salario - 4000.04) * 0.14);
                    Console.WriteLine();
                    Console.WriteLine($"O valor do desconto do INSS deste funcionário é de  R${Math.Round(desconto, 2)}");
                }

                else if (salario > 7786.02)
                {
                    desconto = (1412 * 0.075) + ((2666.68 - 1412.01) * 0.09) + ((4000.03 - 2666.69) * 0.12) + ((7786.02 - 4000.04) * 0.14);
                    Console.WriteLine();
                    Console.WriteLine($"O valor do desconto do INSS deste funcionário é de  R${Math.Round(desconto, 2)}");  
                }

                Console.WriteLine();
                Console.WriteLine("Deseja informar um novo Salário?");
                Console.WriteLine("S: sim, N: não");
                opcao = char.Parse(Console.ReadLine());
                Console.WriteLine();

            } while (opcao == 'S' || opcao == 's' );
                    
            
        }
    }
}
