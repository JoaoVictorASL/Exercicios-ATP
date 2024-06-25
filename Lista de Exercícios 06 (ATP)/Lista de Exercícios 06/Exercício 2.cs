using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m, i, j, cont;

            cont = 0;   

            Console.WriteLine("Informe o número de linhas das 2 matrizes ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o número de colunas das 2 matrizes ");
            m = int.Parse(Console.ReadLine());

            int[,] matriz1 = new int[n, m];
            int[,] matriz2 = new int[n, m];

            bool matrizesIguais;

            matrizesIguais = true;

            Console.WriteLine("\nPreencha a primeira Matriz:\n ");

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.WriteLine($"Linha {i + 1}, coluna {j + 1}: ");
                    matriz1[i, j] = int.Parse(Console.ReadLine()) ;
                }
            }

            Console.WriteLine("\nPreencha a segunda Matriz: \n");

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.WriteLine($"Linha {i + 1}, coluna {j + 1}: ");
                    matriz2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMatriz 1: \n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write(" " + matriz1[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMatriz 2: \n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write(" " + matriz2[i, j]);
                }
                Console.WriteLine();
            }

            for (i = 0; i < n; i++)
            {
                for(j = 0; j < m; j++)
                {
                    if (matriz1[i, j] != matriz2[i, j])
                    {
                        matrizesIguais = false;
                    }

                }
            }

            if (true)
                Console.WriteLine("São matrizes Iguais!");

            else
                Console.WriteLine("São matrizes Diferentes!");

            

            Console.ReadLine();
        }
    }
}
