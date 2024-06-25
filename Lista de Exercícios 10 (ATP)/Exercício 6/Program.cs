using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UsoDeDiscoACME
{
    internal class Program
    {
        const long TamanhoTotalDisco = 53687091200; // 50GB em bytes

        static void Main(string[] args)
        {
            try
            {
                string[] linhas = File.ReadAllLines("usuarios.txt", Encoding.UTF8);
                List<string> linhasRelatorio = new List<string>();

                long usoTotal = 0;
                Dictionary<string, long> usoUsuarios = new Dictionary<string, long>();

                foreach (var linha in linhas)
                {
                    string[] partes = linha.Split('/');
                    if (partes.Length == 2 && long.TryParse(partes[1], out long uso))
                    {
                        string nomeUsuario = partes[0];
                        usoUsuarios[nomeUsuario] = uso;
                        usoTotal += uso;
                    }
                    else
                    {
                        Console.WriteLine($"Linha inválida no arquivo: {linha}");
                    }
                }

                foreach (var usuario in usoUsuarios)
                {
                    double percentualUso = (double)usuario.Value / TamanhoTotalDisco * 100;
                    linhasRelatorio.Add($"{usuario.Key}/{percentualUso:F2}%");
                }

                double percentualUsoTotal = (double)usoTotal / TamanhoTotalDisco * 100;
                linhasRelatorio.Add($"Total de espaço ocupado: {usoTotal} bytes");
                linhasRelatorio.Add($"Percentual de uso do disco: {percentualUsoTotal:F2}%");

                File.WriteAllLines("relatório.txt", linhasRelatorio, Encoding.UTF8);

                Console.WriteLine("Relatório gerado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao processar o arquivo: " + ex.Message);
            }
        }
    }
}
