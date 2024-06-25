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
            int n, lin, col;
            double somaLin, somaCol, somaDiag, somaDiag2;

            Console.WriteLine("Informe o tamanho da Matriz: ");
            n = int.Parse(Console.ReadLine());

            double[,] matriz = new double[n, n];

            for (lin = 0; lin < n; lin++)
            {
                

                for (col = 0; col < n; col++)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Informe os valores da {lin + 1}ª linha e da {col + 1}ª coluna: ");
                    matriz[lin, col] = double.Parse(Console.ReadLine());

                }                
            }
            Console.WriteLine();

            for (lin = 0; lin < n; lin++)
            {
                for (col = 0; col < n; col++)
                {
                    Console.Write(matriz[lin, col]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (lin = 0; lin < n; lin++)
            {
                somaLin = 0;

                for (col = 0; col < n; col++)
                {
                    somaLin += matriz[lin, col];
                }

                Console.WriteLine($"Soma da {lin + 1}ª linha: " + somaLin);
            }
            Console.WriteLine();

            for (col = 0; col < n; col++)
            {
                somaCol = 0;

                for (lin = 0; lin < n; lin++)
                {
                    somaCol += matriz[lin, col];
                }

                Console.WriteLine($"Soma da {col + 1}ª coluna: " + somaCol);
            }
            Console.WriteLine();

            somaDiag = 0;

            for (lin = 0; lin < n; lin++)
            {
                for (col = 0; col < n; col++)
                {
                    if (lin == col)
                    {
                        somaDiag += matriz[lin, col];
                    }
                }

            }

            Console.WriteLine("Soma da diagonal principal: " + somaDiag);
            Console.WriteLine();

            somaDiag2 = 0;

            for (lin = 0; lin < n; lin++)
            {
                for (col = 0; col < n; col++)
                {
                    if (lin + col == (n-1))
                    {
                        somaDiag2 += matriz[lin, col];
                    }
                }
            }

            Console.WriteLine("Soma da diagonal secundária: " + somaDiag2);




            Console.ReadLine();

        }
    }
}
