using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Digite um número:");
            num = int.Parse(Console.ReadLine());

            if (num % 3 == 0 && num % 5 == 0)
                Console.WriteLine("Este número é divisivel por 3 e por 5");

            else Console.WriteLine("Este número não é divisel por 3 e por 5");

            Console.ReadLine();
        }
    }
}
