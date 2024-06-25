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
            double num, raiz, impar;
            int i;

            i = 0;
            impar = 1;

            Console.WriteLine("Digite um número: ");
            num = double.Parse(Console.ReadLine());

            do
            {
                raiz = num - impar;
                impar += 2;
                i++;
                num = raiz;

            } while (raiz > 0);

            Console.WriteLine();    
            Console.WriteLine("A raiz quadrada desse número é: " + i);
            Console.ReadLine();
        }
    }
}
