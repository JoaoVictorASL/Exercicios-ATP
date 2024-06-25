using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_3
{
    internal class Teste
    {
        static void Main(string[] args)
        {
            double raio;

            Console.WriteLine("1º Circulo: \n");
            Console.Write("Informe o raio do circulo: ");
            raio = double.Parse(Console.ReadLine());
            Circulo circulo1 = new Circulo(raio);
            Console.WriteLine();

            Console.WriteLine("Área do Circulo: " + circulo1.CalcularArea());
            Console.WriteLine("Diâmetro do Circulo: " + circulo1.CalcularDiametro());
            Console.WriteLine("Perímetro do Circulo: " + circulo1.CalcularPerimetro());
            Console.WriteLine();

            Console.WriteLine("2º Circulo: \n");
            Console.Write("Informe o raio do circulo: ");
            raio = double.Parse(Console.ReadLine());
            Circulo circulo2 = new Circulo(raio);
            Console.WriteLine();

            Console.WriteLine("Área do Circulo: " + circulo2.CalcularArea());
            Console.WriteLine("Diâmetro do Circulo: " + circulo2.CalcularDiametro());
            Console.WriteLine("Perímetro do Circulo: " + circulo2.CalcularPerimetro());
            Console.WriteLine();


            Console.WriteLine("3º Circulo: \n");
            Console.Write("Informe o raio do circulo: ");
            raio = double.Parse(Console.ReadLine());
            Circulo circulo3 = new Circulo(raio);
            Console.WriteLine();

            Console.WriteLine("Área do Circulo: " + circulo3.CalcularArea());
            Console.WriteLine("Diâmetro do Circulo: " + circulo3.CalcularDiametro());
            Console.WriteLine("Perímetro do Circulo: " + circulo3.CalcularPerimetro());
            Console.WriteLine();


            Console.WriteLine("4º Circulo: \n");
            Console.Write("Informe o raio do circulo: ");
            raio = double.Parse(Console.ReadLine());
            Circulo circulo4 = new Circulo(raio);
            Console.WriteLine();

            Console.WriteLine("Área do Circulo: " + circulo4.CalcularArea());
            Console.WriteLine("Diâmetro do Circulo: " + circulo4.CalcularDiametro());
            Console.WriteLine("Perímetro do Circulo: " + circulo4.CalcularPerimetro());

            Console.ReadLine();
        }
    }
}
