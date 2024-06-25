using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    internal class Program
    {
        static double CalcularHipotenusa(double a, double b)
        {
            return Math.Sqrt(a * a + b * b);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite os valores dos catetos do triângulo:\n");

            Console.Write("Cateto a: ");
            double catetoA = double.Parse(Console.ReadLine());

            Console.Write("Cateto b: ");
            double catetoB = double.Parse(Console.ReadLine());

            double hipotenusa = CalcularHipotenusa(catetoA, catetoB);
            Console.WriteLine($"\nA hipotenusa do triângulo com catetos {catetoA} e {catetoB} é: {hipotenusa}");
        }
    }
}
