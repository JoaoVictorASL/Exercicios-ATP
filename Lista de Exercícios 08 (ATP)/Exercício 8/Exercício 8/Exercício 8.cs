using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string verbo;
            bool teste;
            char opcao;

            do
            {
                Console.Write("Informe um verbo que termine em 'ar': ");
                verbo = Console.ReadLine();

                teste = verbo.EndsWith("ar");

                if (!teste)
                {
                    Console.WriteLine("Palavra Inválida, Tente novamente!");
                }

                else
                {
                    verbo = verbo.Substring(0, verbo.Length - 2);
                    Console.WriteLine("Presente do indicativo: \n");
                    Console.WriteLine($"Eu {verbo}o\n" +
                                      $"Tu {verbo}as\n" +
                                      $"Ele {verbo}a\n" +
                                      $"Nós {verbo}amos\n" +
                                      $"Vós {verbo}ais\n" +
                                      $"Eles {verbo}am\n");

                    Console.WriteLine("\nPretérito perfeito do indicativo: \n");
                    Console.WriteLine($"Eu {verbo}ei\n" +
                                      $"Tu {verbo}aste\n" +
                                      $"Ele {verbo}ou\n" +
                                      $"Nós {verbo}amos\n" +
                                      $"Vós {verbo}astes\n" +
                                      $"Eles {verbo}aram\n");

                    Console.WriteLine("\nFururo do presente do indicativo: \n");
                    Console.WriteLine($"Eu {verbo}arei\n" +
                                      $"Tu {verbo}arás\n" +
                                      $"Ele {verbo}ará\n" +
                                      $"Nós {verbo}aremos\n" +
                                      $"Vós {verbo}areis\n" +
                                      $"Eles {verbo}arão\n");
                }

                Console.WriteLine("Deseja informar um novo Verbo? \nS: sim, N: não");
                opcao = char.Parse(Console.ReadLine());
                Console.WriteLine();

            } while (opcao == 's' || opcao == 'S');
        }
    }
}
