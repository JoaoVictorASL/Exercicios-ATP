using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letra;

            Console.WriteLine("Digite uma Letra:");
            letra = char.Parse(Console.ReadLine());

            switch (letra)
            {
                case 'a':
                    Console.WriteLine("Essa letra é uma Vogal");
                break;

                case 'A':
                    Console.WriteLine("Essa letra é uma Vogal");
                break;

                case 'e':
                    Console.WriteLine("Essa letra é uma Vogal");
                break;

                case 'E':
                    Console.WriteLine("Essa letra é uma Vogal");
                break;

                case 'i':
                    Console.WriteLine("Essa letra é uma Vogal");
                break;

                case 'I':
                    Console.WriteLine("Essa letra é uma Vogal");
                break;

                case 'o':
                    Console.WriteLine("Essa letra é uma Vogal");
                break;

                case 'O':
                    Console.WriteLine("Essa letra é uma Vogal");
                break;

                case 'u':
                    Console.WriteLine("Essa letra é uma Vogal");
                break;

                case 'U':
                    Console.WriteLine("Essa letra é uma Vogal");
                break;

                default:
                    Console.WriteLine("Essa letra é uma Consoante");
                break ;
            }
            Console.ReadLine();
        }
    }
}
