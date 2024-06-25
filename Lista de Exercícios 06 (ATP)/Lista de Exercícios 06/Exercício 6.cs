using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 4];
            int i, j;

            bool TrianguloSuperior = true;


            Console.WriteLine(" Preencha a Matriz: \n");
            for (i = 0; i < matriz.GetLength(0); i++) 
            {
                for (j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine($" Linha {i + 1}, Coluna {j + 1}: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }      

            Console.WriteLine(" Matriz: \n");
            for (i = 0; i < matriz.GetLength(0); i++)
            {
                for (j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("  " + matriz[i, j]);
                }
                Console.WriteLine();
            }

            for (j = 0; j < matriz.GetLength(1); j++)
            {
                for (i = 0; i < matriz.GetLength(0); i++)
                {
                    if(i > j && matriz[i, j] != 0)
                    {
                        TrianguloSuperior = false;   
                        break;
                    }                  
                }
                if (!TrianguloSuperior)
                    break;
            }

            if (TrianguloSuperior)
                Console.WriteLine("\nEssa Matriz é um Triângulo Superior!");
            else
                Console.WriteLine("\nEssa Matriz não é um Triângulo Superior!");

            Console.ReadLine();
        }
    }
}
