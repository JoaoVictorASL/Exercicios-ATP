using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string csv = "nome,idade,sexo\nAna,25,F\nJoão,30,M\nMaria,22,F";
            string[,] matriz = ConverterParaMatriz(csv);

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }


        static string[,] ConverterParaMatriz(string csv)
        {
            string[] linhas = csv.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            int numLinhas = linhas.Length;
            int numColunas = linhas[0].Split(',').Length;

            string[,] matriz = new string[numLinhas, numColunas];

            for (int i = 0; i < numLinhas; i++)
            {
                string[] colunas = linhas[i].Split(',');

                for (int j = 0; j < numColunas; j++)
                {
                    matriz[i, j] = colunas[j];
                }
            }

            return matriz;
        }
    }

}
