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
            double[] notas = new double[60];
            double somaNotas = 0;
            double media;

            int contNota = 0;

            for (int i = 0; i < notas.Length; i++, contNota++)
            {
                Console.WriteLine($"Informe a {contNota + 1}ª nota: ");
                double nota = double.Parse(Console.ReadLine());
                Console.WriteLine();

                if (nota < 0)
                    break;

                notas[i] = nota;
                somaNotas += notas[i];
            }

            media = contNota == 0 ? 0 : somaNotas / contNota;

            Console.WriteLine("Notas válidas:");
            for (int j = 0; j < contNota; j++)
            {
                Console.WriteLine($"{j + 1}ª Nota: {notas[j]}");
            }

            Console.WriteLine();
            Console.WriteLine("Média das notas: " + media);
            Console.WriteLine();

            Console.Write("Notas acima da Média: ");

            for (int j = 0; j < contNota; j++)
            {
                if (notas[j] > media)
                    Console.Write($"{notas[j]}, ");
            }

            Console.ReadLine();
        }
    }
}
