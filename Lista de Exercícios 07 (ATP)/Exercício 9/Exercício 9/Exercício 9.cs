using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_9
{
    internal class Program
    {
        static void ObterMaiorMenor(float[] vet, out float menor, out float maior)
        {
            menor = float.MaxValue;
            maior = float.MinValue;

            foreach (float num in vet)
            {
                if (num < menor)
                    menor = num;

                else if (num > maior)
                    maior = num;
            }
            Console.WriteLine("\nO menor elemento do vetor é: " + menor);
            Console.WriteLine("O maior elemento do vetor é: " + maior);
        }
        static void Main(string[] args)
        {
            float[] vetor = new float[5];
            float menor;
            float maior;

            Console.WriteLine("Preencha o Vetor: ");
            for (int i = 0; i < vetor.Length; i++) 
            {
                Console.Write($"\n{i + 1}º Elemento: ");
                vetor[i] = float.Parse(Console.ReadLine());
            }
            ObterMaiorMenor(vetor, out menor, out maior);

            Console.ReadLine();
        }
    }
}
