using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_10
{
    internal class Program
    {
        static int[] InterseçãoVetores(int[] vetorA, int[] vetorB)
        {
            List<int> vetorC = new List<int>();

            for (int i = 0; i < vetorA.Length; i++)
            {
                for (int j = 0; j < vetorB.Length; j++)
                {
                    if (vetorA[i] == vetorB[j] && !vetorC.Contains(vetorA[i]))
                    {
                        vetorC.Add(vetorA[i]);
                        break; 
                    }
                }
            }

            return vetorC.ToArray();
        }
        static void LerVetor(int[] vetor)
        {
            for(int i = 0; i < vetor.Length; i++) 
            {
                Console.Write($" Aluno {i + 1}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }
        static void Main(string[] args)
        {
            int[] Atp = new int[10];
            int[] Diw = new int[10];

            Console.WriteLine("Informe o número de matrícula dos alunos matriculados em Algoritmos e Técnicas de Programação:\n");
            LerVetor(Atp);
            Console.WriteLine("\nInforme o número de matrícula dos alunos matriculados em Desenvolvimento de Interfaces Web:\n");
            LerVetor(Diw);

            int[] intersecao = InterseçãoVetores(Atp, Diw);

            if (intersecao.Length > 0)
            {
                Console.WriteLine("\nNúmero de matrícula dos alunos matriculados em ambas as disciplinas:\n");
                foreach (int matricula in intersecao)
                {
                    Console.WriteLine(" " + matricula);
                }
            }
            else
            {
                Console.WriteLine("\nNão existem alunos matriculados simultaneamente nas duas disciplinas.");
            }

            Console.ReadLine();

        }
    }
}
