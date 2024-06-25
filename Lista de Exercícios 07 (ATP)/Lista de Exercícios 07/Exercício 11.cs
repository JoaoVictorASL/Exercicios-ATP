using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_11
{
    internal class Program
    {
        static void ConverterSegundos(int totalSegundos, out int hora, out int min, out int seg)
        {
            hora = totalSegundos / 3600;
            min = (totalSegundos % 3600) / 60;
            seg = totalSegundos % 60;

            Console.WriteLine($"\nHorário Convertido: {hora}:{min}:{seg}");
        }
        static void Main(string[] args)
        {
            int segundos;

            Console.WriteLine("Informe a quantidade total de segundos: ");
            segundos = int.Parse(Console.ReadLine());
            ConverterSegundos(segundos, out int hora, out int min, out int seg);

            Console.ReadLine();
        }
    }
}
