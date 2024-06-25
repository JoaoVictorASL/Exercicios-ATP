using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] notas = new double[200];
            double menorNota, maiorNota, somaNota, mediaNota, cont, escolha;
            int i, opcao;

            menorNota = double.MaxValue;
            maiorNota = double.MinValue;
            somaNota = 0;
            cont = 0;

            for (i = 0; i < notas.Length; i++)
            {
                do
                {
                    Console.WriteLine("Informe uma nota entre 0 e 100:");
                    notas[i] = double.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (notas[i] < 0 || notas[i] > 100)
                    {
                        Console.WriteLine("Nota Inválida!");
                    }

                } while (notas[i] < 0 || notas[i] > 100);

                somaNota += notas[i];

                if (notas[i] < menorNota)
                    menorNota = notas[i];

                if (notas[i] > maiorNota)
                    maiorNota = notas[i];
            }

            mediaNota = somaNota / notas.Length;

            for (i = 0; i < notas.Length; i++)
            {
                if (notas[i] > mediaNota)
                cont++;
            }

            do
            {
                Console.WriteLine();
                Console.WriteLine("Escolha uma das opções:");
                Console.WriteLine();
                Console.WriteLine("1. Mostrar menor nota");
                Console.WriteLine("2. Mostrar maior nota");
                Console.WriteLine("3. Pesquisar nota");
                Console.WriteLine("4. Mostrar média das notas e quantidade de notas acima da média");
                Console.WriteLine("5. Sair");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"{menorNota} Foi a menor nota registrada.");
                    break;

                    case 2:
                        Console.WriteLine($"{maiorNota} Foi a maior nota registrada.");
                    break;

                    case 3:
                        {
                            Console.Write("Pesquise uma Nota: ");
                            escolha = double.Parse(Console.ReadLine());

                            Console.Write($"A nota {escolha} consta nas posições: ");

                            for (i = 0; i < notas.Length; i++)
                            {
                                if (escolha == notas[i])
                                    Console.Write(" " + (i + 1));
                            }
                        }
                    break;

                    case 4:
                        {
                            Console.WriteLine("A média das notas: " + mediaNota);
                            Console.WriteLine("Quantidade de notas acima da média: " + cont);
                        }
                    break;

                    case 5:
                    break;

                    default:
                        Console.WriteLine("Opção Inválida, tente novamente!");
                    break;
                }
            } while (opcao != 5);





        }
    }
}
