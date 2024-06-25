using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_6
{
    class Program
    {
        static void PreencherMatriz(int[,] matriz)
        {
            Random R = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = R.Next(1, 10);
                }
            }
        }
        static void ImprimirMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("  " + matriz[i, j]);
                }
                Console.WriteLine();
            }

        }
        static void MultiplicarEscalar(int[,] matriz, int num)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] *= num; 
                }
            }

        }
        static void Main(string[] args)
        {
            int[,] matrizOriginal = new int[3, 3];
            int valor;

            PreencherMatriz(matrizOriginal);

            Console.WriteLine("Matriz Original:\n");
            ImprimirMatriz(matrizOriginal);

            Console.Write("\nInforme um valor para multiplicar a Matriz: ");
            valor = int.Parse(Console.ReadLine());

            MultiplicarEscalar(matrizOriginal, valor);

            Console.WriteLine("\nMatriz Multiplicada:\n");
            ImprimirMatriz(matrizOriginal);

            Console.ReadLine();
        }
    }
}
