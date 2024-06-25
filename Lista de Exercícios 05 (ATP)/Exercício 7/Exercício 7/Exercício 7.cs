using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[5];
            int[] y = new int[5];
            int i, j, soma, produto, diferenca, intersecao, uniao;

            for (i = 0; i < x.Length; i++) 
            {
                Console.WriteLine($"\nInforme o {i + 1}º valor do Vetor X:");
                x[i] = int.Parse( Console.ReadLine());
            }

            for (i = 0; i < x.Length; i++)
            {
                Console.WriteLine($"\nInforme o {i + 1}º valor do Vetor Y:");
                y[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nSoma entre X e Y:\n");
            for (i = 0; i < x.Length; i++)
            { 
                soma = x[i] + y[i];
                Console.WriteLine($"{x[i]} + {y[i]} = {soma}");
            }

            Console.WriteLine("\nProduto entre X e Y:\n");
            for (i = 0; i < x.Length; i++)
            {
                produto = x[i] * y[i];
                Console.WriteLine($"{x[i]} * {y[i]} = {produto}");
            }

            Console.WriteLine("\nElementos de X que não existem em Y:\n");
            for (i = 0; i < x.Length; i++)
            {
                bool encontrado = false; 

                for (j = 0; j < y.Length; j++)
                {
                    if (x[i] == y[j])
                    {
                        encontrado = true;
                        break;
                    }
                }

                if (!encontrado)
                {
                    Console.WriteLine("" + x[i]);
                }
            }

            Console.WriteLine("\nInterseção entre X e Y:\n");
            for (i = 0; i < x.Length; i++)
            {
                for (j = 0; j < y.Length; j++)
                {
                    if (x[i] == y[j])
                    {
                        Console.WriteLine("" + x[i]);
                        break;
                    }
                }
            }

            Console.WriteLine("\nUnião entre X e Y:\n");
            for (i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }

            for (i = 0; i < y.Length; i++)
            {
                bool duplicado = false;
                for (j = 0; j < x.Length; j++)
                {
                    if (y[i] == x[j])
                    {
                        duplicado = true;
                        break;
                    }
                }
                if (!duplicado)
                {
                    Console.WriteLine(y[i]);
                }
            }


            Console.ReadLine();
        }
    }
}
