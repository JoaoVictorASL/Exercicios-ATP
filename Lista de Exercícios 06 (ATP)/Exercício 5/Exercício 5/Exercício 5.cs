using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[500, 500];
            int i, j, valorX, somalin, somaCol, somaDiag, somaDiag2;
            Random random = new Random();

            bool condicao1 = true;
            bool condicao2 = true;
            bool condicao3 = true;
            bool condicao4 = true;


            valorX = 0;

            Console.WriteLine(" Preencha a Matriz: ");
            for (i = 0; i < matriz.GetLength(0); i++) 
            {
                for (j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.Next(0, 10);
                }
            }

            Console.WriteLine("\n Matriz: \n");
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
                valorX += matriz[0, j];
            }

            for (i = 0; i < matriz.GetLength(0); i++)
            {
                somalin = 0;
                for (j = 0; j < matriz.GetLength(1); j++)
                {
                    somalin += matriz[i, j];
                }
                condicao1 = (somalin != valorX) ? false : condicao1;
            }

            for (j = 0; j < matriz.GetLength(0); j++)
            {
                somaCol = 0;
                for (i = 0; i < matriz.GetLength(1); i++)
                {
                    somaCol += matriz[i, j];    
                }
                condicao2 = (somaCol != valorX) ? false : condicao2;  
            }

            somaDiag = 0;
            for (i = 0; i < matriz.GetLength(0); i++)
            {
                for (j = 0; j < matriz.GetLength(1); j++)
                {
                    somaDiag += (i == j) ? matriz[i, j] : 0;
                }               
            }
            condicao3 = (somaDiag != valorX) ? false : condicao3;

            somaDiag2 = 0;
            for (i = 0; i < matriz.GetLength(0); i++)
            {
                somaDiag2 += matriz[i, matriz.GetLength(1) - 1 - i];
            }
            condicao4 = (somaDiag2 != valorX) ? false : condicao4;

            if (condicao1 == false || condicao2 == false || condicao3 == false || condicao4 == false)
            {
                Console.WriteLine("\nEssa Matriz não é um Quadrado mágico!");
            }

            else
            {
                Console.WriteLine("\nEssa Matriz é um Quadrado mágico!");
            }

            Console.ReadLine();
        }
    }
}
