using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_4
{
    internal class Program
    {
        static int LerArq1(int[] pesos, string[] nomes)
        {
            int i = 0;
            try
            {
                string[] dados;
                string linha;
                StreamReader arq = new StreamReader("arquivo-01.txt", Encoding.UTF8);
                linha = arq.ReadLine();
                while (linha != null)
                {
                    dados = linha.Split(';');
                    nomes[i] = dados[0];
                    pesos[i] = int.Parse(dados[3]);
                    i++;
                    linha = arq.ReadLine();
                }
                arq.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro" + ex.Message);
            }
            return i;
        }
        static int LerArq2(int[,] intervalos)
        {
            int i = 0;
            try
            {
                string[] dados;
                string linha;
                StreamReader arq = new StreamReader("arquivo-02.txt", Encoding.UTF8);
                linha = arq.ReadLine();
                while (linha != null)
                {
                    dados = linha.Split(';');
                    intervalos[i, 0] = int.Parse(dados[0]);
                    intervalos[i, 1] = int.Parse(dados[1]);
                    i++;
                    linha = arq.ReadLine();
                }
                arq.Close();
            }
            catch (Exception ex) { Console.WriteLine("Erro" + ex.Message); }
            return i;

        }
        static void VerificarPesos(int[,] intervalos, string[] nomes, int[] pesos, int quantIntervalos, int quantDados)
        {
            int min, max;
            for (int linha = 0; linha < quantIntervalos; linha++)
            {
                min = intervalos[linha, 0];
                max = intervalos[linha, 1];
                Console.WriteLine($"Intervalo: [{min},{max}]");
                for (int i = 0; i < quantDados; i++)
                {
                    if (pesos[i] >= min && pesos[i] <= max)
                        Console.WriteLine(nomes[i]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[] pesos = new int[100];
            string[] nomes = new string[100];
            int[,] intervalos = new int[100, 2];
            int quantDados = LerArq1(pesos, nomes);
            int quantIntervalos = LerArq2(intervalos);
            VerificarPesos(intervalos, nomes, pesos, quantIntervalos, quantDados);
            Console.ReadLine();
        }
    }
}
