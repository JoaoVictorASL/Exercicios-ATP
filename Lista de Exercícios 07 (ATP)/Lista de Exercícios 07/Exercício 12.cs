using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_12
{
    internal class Program
    {
        static int PercorrerMatriz(int[,] Matriz, out int lin, out int col)
        {
            lin = -1;
            col = -1;
            int K = int.MinValue;

            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    if (Matriz[i, j] > K)
                    {
                        K = Matriz[i, j];
                        lin = i;
                        col = j;
                    }
                }
            }
            return K;
        }
    
        static void PreencherMatriz(int[,] Matriz)
        {
            Console.WriteLine("Preencha a Matriz: \n");
            for(int i = 0; i < Matriz.GetLength(0); i++) 
            {
                for(int j = 0; j < Matriz.GetLength(1); j++)
                {
                    Console.Write($"Linha {i}, Coluna {j}: ");
                    Matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];
            PreencherMatriz(matriz);

            int maxValue;
            int maxRow, maxCol;
            maxValue = PercorrerMatriz(matriz, out maxRow, out maxCol);

            Console.WriteLine($"\nO maior valor da matriz é {maxValue}, localizado na linha {maxRow}, coluna {maxCol}.");
            Console.ReadLine();

        }
    }
}
