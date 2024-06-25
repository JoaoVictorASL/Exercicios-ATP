using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double h, pesohomem, pesomulher, pesoideal;
            char sexo;

            Console.WriteLine("Informe sua Altura em Metros:");
            h = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu Sexo com F (feminino) ou M (masculino):");
            sexo = char.Parse(Console.ReadLine());

            pesohomem = (72.7 * h) - 58;
            pesomulher = (62.1 * h) - 44.7;

            pesoideal = (sexo == 'M') ? (pesohomem) : (pesomulher);
            Console.WriteLine("O Peso ideal seria:" + pesoideal);

            Console.ReadLine();
        }
    }
}
