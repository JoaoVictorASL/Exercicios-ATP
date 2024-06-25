    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetA = new double[10];
            double[] vetB = new double[10];
            char[] vetC = new char[10];     
            double[] vetD = new double[10];

            int i;

            for (i = 0; i < vetA.Length; i++)
            {
                Console.WriteLine("\nInforme um valor: ");
                vetA[i] = double.Parse(Console.ReadLine()); 

                Console.WriteLine("\nInforme a operação que deseja fazer: ");
                vetC[i] = char.Parse(Console.ReadLine());

                Console.WriteLine("\nInforme um segundo valor: ");
                vetB[i] = double.Parse(Console.ReadLine());


                if (vetC[i] == '+')
                {
                    vetD[i] = vetA[i] + vetB[i];
                    Console.WriteLine($"\n{vetA[i]} + {vetB[i]} = {vetD[i]}");
                }

                else if (vetC[i] == '-')
                {
                    vetD[i] = vetA[i] - vetB[i];
                    Console.WriteLine($"\n{vetA[i]} - {vetB[i]} = {vetD[i]}");
                }

                else if (vetC[i] == '*')
                {
                    vetD[i] = vetA[i] * vetB[i];
                    Console.WriteLine($"\n{vetA[i]} x {vetB[i]} = {vetD[i]}");
                }

                else if (vetC[i] == '/')
                {
                    vetD[i] = vetA[i] / vetB[i];
                    Console.WriteLine($"\n{vetA[i]} / {vetB[i]} = {vetD[i]}");
                }
            }

            Console.ReadLine();


        }
    }
}
