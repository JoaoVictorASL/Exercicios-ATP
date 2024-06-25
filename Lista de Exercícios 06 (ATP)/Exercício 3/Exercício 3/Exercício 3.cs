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
            int i, j;
            int[,] matriz = new int[10, 10];

            Random random = new Random();   

            for (i = 0; i < matriz.GetLength(0); i++)
            {
                for (j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.Next(11, 100);
                }
            }

            Console.WriteLine("Matriz: \n");

            for (i = 0;i < matriz.GetLength(0); i++)
            {
                for(j = 0;j < matriz.GetLength(1);j++)
                {
                    Console.Write(" " + matriz[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMatriz modificada: \n");

            for (i = 0; i < matriz.GetLength(0); i++)
            {
                for (j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write(" " + (Math.Sqrt(matriz[i, j]).ToString("F1")));
                    }
                    else
                    {
                        Console.Write(" " + matriz[i, j]);
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
                
        }
    }
}
