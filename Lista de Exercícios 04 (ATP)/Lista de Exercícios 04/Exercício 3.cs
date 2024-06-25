using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precoKwh, consumoKwh, consumoMax, consumoMin, consumoSoma;
            int c;

            consumoMax = double.MinValue;
            consumoMin = double.MaxValue;
            consumoSoma = 0;

            for (c = 0; c < 3; c++)
            {
                Console.WriteLine();
                Console.WriteLine("Informe o preço do kWh: ");
                precoKwh = double.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Informe a quantidade de kWh consumidos durante o mês: ");
                consumoKwh = double.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Valor a ser pago: " +  precoKwh * consumoKwh);

                if (consumoKwh > consumoMax) 
                    consumoMax = consumoKwh;
                
                if (consumoKwh < consumoMin)
                    consumoMin = consumoKwh;

                consumoSoma += consumoKwh; 
            }

            Console.WriteLine();
            Console.WriteLine("Consumo médio dos consumidores da cidade: " + consumoSoma / 3);

            Console.WriteLine();
            Console.WriteLine("O maior consumo verificado: " + consumoMax);

            Console.WriteLine();
            Console.WriteLine("O menor consumo verificado: " + consumoMin);

            Console.ReadLine();

        }
    }
}
