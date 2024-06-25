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
            double[,] matriz = new double[3, 6];
            double somaColunaImp, somaColuna24, somaColuna12;
            Random random = new Random();
            int i, j;

            somaColunaImp = 0;
            somaColuna24 = 0;

            for (i = 0; i < matriz.GetLength(0); i++) 
            {
                for (j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.NextDouble() * 9;
                }
            }

            Console.WriteLine(" Matriz preenchida: \n");
            for (i = 0; i < matriz.GetLength(0); i++)
            {
                for (j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("  " + matriz[i, j].ToString("F2"));
                }
                Console.WriteLine();
            }

            for (i = 0; i < matriz.GetLength(0); i++)
            {
                for (j = 0; j < matriz.GetLength(1); j++)
                {
                    if (j == 1 || j == 3 || j == 5)
                        somaColunaImp += matriz[i, j];

                    if (j == 1 || j == 3)
                        somaColuna24 += matriz[i, j];   
                }
            }


            Console.WriteLine("\n Soma de todos os elementos das colunas ímpares: \n");
            Console.WriteLine("  " + somaColunaImp.ToString("F2"));

            Console.WriteLine("\n Média dos elementos da segunda e quarta colunas: \n");
            Console.WriteLine("  " + (somaColuna24 / 6).ToString("F2"));

            Console.WriteLine("\n Matriz modificada: \n");
            for (i = 0; i < matriz.GetLength(0); i++)
            {
                somaColuna12 = 0;

                for (j = 0; j < matriz.GetLength(1); j++)
                {

                    if (j == 0 || j == 1)
                        somaColuna12 += matriz[i, j];

                    if (j == 5)
                    {
                        matriz[i, j] = somaColuna12;
                    }
                    Console.Write("  " + matriz[i, j].ToString("F2"));
                }
                Console.WriteLine();
            }



            Console.ReadLine();

        }
    }
}
