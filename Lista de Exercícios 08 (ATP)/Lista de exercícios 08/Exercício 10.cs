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
            string A;
            string B;
            int cont = 0;

            Console.WriteLine("Informe uma frase com no mínimo 50 caracteres: \n");
            A = Console.ReadLine();

            if (A.Length < 10)
                Console.WriteLine("\nFrase inválida!");

            else
            {
                Console.Write("\nInforme 2 caracteres: ");
                B = Console.ReadLine();

                if (B.Length > 2 || B.Length < 2)
                    Console.WriteLine("\nNúmero de caracteres inválidos!");

                else
                {
                    for (int i = 0; i < A.Length; i++)
                    {
                        if (A[i] == B[0] && A[i + 1] == B[1])
                            cont++;
                    }
                }
            }

            Console.WriteLine("\nNúmero de vezes que os caracteres aparecem na frase: " + cont);
            Console.ReadLine();
        }
    }
}
