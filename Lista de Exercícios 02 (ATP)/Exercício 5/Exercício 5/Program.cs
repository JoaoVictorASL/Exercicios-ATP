using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Informe a idade:");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 5 && idade <= 7)
                Console.WriteLine("Classificado na categoria Infantil A");

            else if (idade >= 8 && idade <= 10)
                Console.WriteLine("Classificado na categoria Infantil B");

            else if (idade >= 11 && idade <= 13)
                Console.WriteLine("Classificado na categoria Juvenil A");

            else if (idade >= 14 && idade <= 17)
                Console.WriteLine("Classificado na categoria Juvenil B");

            else if (idade >= 18)
                Console.WriteLine("Classificado na categoria Sênior");
            
            Console.ReadLine();

        }
    }
}
