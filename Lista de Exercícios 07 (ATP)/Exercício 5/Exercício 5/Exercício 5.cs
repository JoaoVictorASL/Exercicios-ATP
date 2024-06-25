using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_5
{
    class Program
    {
        static int Vogais(char[] vetor)
        {
            int cont;
            cont = 0;

            foreach(char Letra in vetor)
            {
                if (Letra == 'a' || Letra == 'e' || Letra == 'i' || Letra == 'o' || Letra == 'u')
                    cont++;
            }
            return cont;
        }
        static void Main(string[] args)
        {
            char[] vet = new char[10];
            int i;

            Console.WriteLine("Preencha o Vetor com Letras\n");

            for (i = 0; i < vet.Length; i++)
            {
                Console.Write($"Informe a {i + 1}ª letra: ");
                vet[i] = char.Parse(Console.ReadLine());
            }

            int numVogais = Vogais(vet);
            Console.WriteLine($"\nEsse vetor possui {numVogais} vogais! ");

            Console.ReadLine();

        }
    }
}
