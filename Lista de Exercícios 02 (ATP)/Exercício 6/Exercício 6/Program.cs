using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int w, x, y, z;
            double mediageo, mediapond, mediaharm, mediaarit;

            Console.WriteLine("Informe o valor de w de 1 a 4:");
            w = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de x:");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de y:");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor de z:");
            z = int.Parse(Console.ReadLine());

            mediageo = Math.Sqrt(x * y * z);
            mediapond = (x + 2 * y + 3 * z / 6);
            mediaharm = 1 / 1 / x + 1 / y + 1 / z;
            mediaarit = (x + y + z) / 3;

            if (w == 1) {
                Console.WriteLine("A média Geométrica é:" + mediageo);
                Console.ReadLine();
            }

            else if (w == 2) {
                Console.WriteLine("A média Ponderada é:" + mediapond);
                Console.ReadLine();
            }

            else if (w == 3) {
                Console.WriteLine("A média Harmônica é:" + mediaharm);
                Console.ReadLine();
            }

            else if (w == 4) {
                Console.WriteLine("A média Aritmética é:" + mediaarit);
                Console.ReadLine();
            }

            else if (w > 4 || w < 1) { 
                Console.WriteLine("Número Inválido");
                Console.ReadLine();
            }
        }
    }
}