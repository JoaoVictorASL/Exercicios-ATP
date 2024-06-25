using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temp = new double[31];
            double escolha;
            int i;

            for (i = 0; i < temp.Length; i++) 
            {
                Console.WriteLine("Informe a temperatura: ");
                temp[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("Pesquise uma temperatura: ");
            escolha = double.Parse(Console.ReadLine());

            Console.Write("Essa temperatura ocorreu nos dias: ");

            for (i = 0; i < temp.Length; i++)
            {

                if (escolha == temp[i])
                    Console.Write(" " + (i+1));

            }

            Console.ReadLine();


        }
    }
}
