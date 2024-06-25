using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] matriz;
            int lin, col, jogadas;
            char opc;
            bool vitoria;

            do
            {
                matriz = new char[3, 3];
                jogadas = 0;
                vitoria = false;

                while (jogadas < 9 && !vitoria)
                {
                    Console.WriteLine($"\nJogador {(jogadas % 2 == 0 ? 1 : 2)}, informe a posição que deseja jogar:");
                    Console.Write("Linha: ");
                    lin = int.Parse(Console.ReadLine());
                    Console.Write("Coluna: ");
                    col = int.Parse(Console.ReadLine());

                    if (matriz[lin, col] == '\0')
                    {
                        char jogadorAtual = jogadas % 2 == 0 ? 'X' : 'O';
                        matriz[lin, col] = jogadorAtual;

                        if ((matriz[lin, 0] == jogadorAtual && matriz[lin, 1] == jogadorAtual && matriz[lin, 2] == jogadorAtual) ||
                            (matriz[0, col] == jogadorAtual && matriz[1, col] == jogadorAtual && matriz[2, col] == jogadorAtual) ||
                            (lin == col && matriz[0, 0] == jogadorAtual && matriz[1, 1] == jogadorAtual && matriz[2, 2] == jogadorAtual) ||
                            (lin + col == 2 && matriz[0, 2] == jogadorAtual && matriz[1, 1] == jogadorAtual && matriz[2, 0] == jogadorAtual))
                        {
                            vitoria = true;
                            Console.WriteLine($"\nO jogador {(jogadas % 2 == 0 ? 1 : 2)} venceu!");
                        }
                        else
                        {
                            jogadas++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nJogada Inválida! Tente novamente.");
                    }

                    Console.WriteLine();
                    for (int i = 0; i < matriz.GetLength(0); i++)
                    {
                        for (int j = 0; j < matriz.GetLength(1); j++)
                        {
                            Console.Write("  " + (matriz[i, j] == '\0' ? '-' : matriz[i, j]));
                        }
                        Console.WriteLine();
                    }
                }

                if (!vitoria && jogadas == 9)
                {
                    Console.WriteLine("\nO jogo empatou!");
                }

                Console.WriteLine("\nDeseja jogar novamente? (S: sim, N: não)");
                opc = char.Parse(Console.ReadLine());

            } while (opc == 's' || opc == 'S');

            Console.WriteLine("Jogo encerrado.");
            Console.ReadLine();
        }
    }
}
