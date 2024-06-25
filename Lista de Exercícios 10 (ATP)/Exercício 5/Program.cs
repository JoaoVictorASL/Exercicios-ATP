using System;
using System.IO;
using System.Text;

namespace Exercício_5
{
    internal class Program
    {
        static int LerArq1(int[] pesos, string[] nomes)
        {
            int i = 0;
            try
            {
                using (StreamReader arq = new StreamReader("arquivo-01.txt", Encoding.UTF8))
                {
                    string linha;
                    while ((linha = arq.ReadLine()) != null)
                    {
                        string[] dados = linha.Split(';');
                        if (dados.Length > 3)
                        {
                            nomes[i] = dados[0];
                            if (int.TryParse(dados[3], out int peso))
                            {
                                pesos[i] = peso;
                                i++;
                            }
                            else
                            {
                                Console.WriteLine($"Erro ao converter peso: {dados[3]} na linha {i + 1}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Formato inválido na linha {i + 1}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao ler arquivo-01.txt: " + ex.Message);
            }
            return i;
        }

        static int LerArq2(int[,] intervalos)
        {
            int i = 0;
            try
            {
                using (StreamReader arq = new StreamReader("arquivo-02.txt", Encoding.UTF8))
                {
                    string linha;
                    while ((linha = arq.ReadLine()) != null)
                    {
                        string[] dados = linha.Split(';');
                        if (dados.Length == 2 && int.TryParse(dados[0], out int min) && int.TryParse(dados[1], out int max))
                        {
                            intervalos[i, 0] = min;
                            intervalos[i, 1] = max;
                            i++;
                        }
                        else
                        {
                            Console.WriteLine($"Formato inválido ou erro ao converter intervalo na linha {i + 1}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao ler arquivo-02.txt: " + ex.Message);
            }
            return i;
        }

        static void VerificarPesos(int[,] intervalos, string[] nomes, int[] pesos, int quantIntervalos, int quantDados)
        {
            try
            {
                using (StreamWriter arq3 = new StreamWriter("arquivo-03.txt", false, Encoding.UTF8))
                {
                    for (int linha = 0; linha < quantIntervalos; linha++)
                    {
                        int min = intervalos[linha, 0];
                        int max = intervalos[linha, 1];
                        Console.WriteLine($"Intervalo: [{min},{max}]");
                        bool encontrou = false;
                        for (int i = 0; i < quantDados; i++)
                        {
                            if (pesos[i] >= min && pesos[i] <= max)
                            {
                                Console.WriteLine(nomes[i]);
                                arq3.WriteLine(nomes[i]);
                                encontrou = true;
                            }
                        }
                        if (!encontrou)
                        {
                            Console.WriteLine("Nenhum nome encontrado nesse intervalo.");
                        }
                        Console.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao escrever no arquivo-03.txt: " + ex.Message);
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
