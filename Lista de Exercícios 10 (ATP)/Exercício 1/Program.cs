using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercício_1
{
    class Program
    {
        static void ImprimirNomeCientifico(StreamReader arq)
        {
            string linha;
            linha = arq.ReadLine();
            string[] vet;

            Console.WriteLine("Nome Científico: \n");
            while (linha != null)
            {
                vet = linha.Split(';');

                Console.WriteLine(vet[1]);
                linha = arq.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            string linha;
            try
            {
                StreamReader arq = new StreamReader("arquivo-01.txt", Encoding.UTF8);
                ImprimirNomeCientifico(arq);
                /*linha = arq.ReadLine();

                while(linha != null)
                {
                    Console.WriteLine(linha);
                    linha = arq.ReadLine();
                }*/
                arq.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
