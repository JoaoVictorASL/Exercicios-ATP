using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 4];
            int i, j, maiorNota, mediaNotas, somaNotas;

            maiorNota = 0;
            somaNotas = 0;

            for (i = 0; i < matriz.GetLength(0); i++)
            {
                for (j = 0; j < matriz.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Console.WriteLine($"Informe o número de matrícula do {i + 1}º Aluno: ");
                        matriz[i, j] = int.Parse(Console.ReadLine());
                    }

                    else if (j == 1)
                    {
                        Console.WriteLine($"\nInforme a média das provas do {i + 1}º Aluno: ");
                        matriz[i, j] = int.Parse(Console.ReadLine());
                    }

                    else if (j == 2)
                    {
                        Console.WriteLine($"\nInforme a média dos trabalhos do {i + 1}º Aluno: ");
                        matriz[i, j] = int.Parse(Console.ReadLine());
                    }

                    else if (j == 3)
                    {
                        matriz[i, j] = matriz[i, 1] + matriz[i, 2];
                        somaNotas += matriz[i, j]; 
                        if (matriz[i, j] > maiorNota)
                            maiorNota = matriz[i, 0];
                    }
                }
                Console.WriteLine();
            }

            mediaNotas = somaNotas / matriz.GetLength(0);

            Console.WriteLine(" \nMatriz: \n");
            for (i = 0; i < matriz.GetLength(0); i++)
            {
                for (j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(" " + matriz[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine(" \nNúmero de matrícula do aluno com a maior nota: \n");
            Console.WriteLine(" " + maiorNota);

            Console.WriteLine(" \nMédia das notas finais: \n");
            Console.WriteLine(" " + mediaNotas);


            Console.ReadLine();
        }
    }
}
