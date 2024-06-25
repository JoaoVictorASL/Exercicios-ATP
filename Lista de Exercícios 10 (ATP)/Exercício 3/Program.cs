using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercício_3
{
    internal class Program
    {
        static void IdadeEmCativeiro(StreamReader arq)
        {
            string linha;
            string[] vet;

            linha = arq.ReadLine();

            Console.WriteLine("Animais com idade máxima entre 10 e 16 anos: \n");
            while (linha != null)
            {
                vet = linha.Split(';');

                if (int.Parse(vet[4]) > 10 && int.Parse(vet[4]) < 16)
                {
                    Console.WriteLine(vet[0]);
                }
                linha = arq.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            try
            {
                StreamReader arq = new StreamReader("arquivo-01.txt", Encoding.UTF8);
                IdadeEmCativeiro(arq);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
