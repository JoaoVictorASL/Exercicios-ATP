using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temp, tempMax, tempMin;
            int i, diaMax, diaMin;

            tempMax = double.MinValue;
            tempMin = double.MaxValue;

            diaMax = int.MinValue;
            diaMin = int.MaxValue;

            for (i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Informe a temperatura média do dia { i } em graus celsius: ");
                temp = double.Parse( Console.ReadLine());

                if (temp > tempMax)
                {
                    tempMax = temp;
                    diaMax = i;
                }

                if (temp < tempMin)
                {
                    tempMin = temp;
                    diaMin = i;
                }
                Console.WriteLine();
            }

            Console.WriteLine($"A maior temperatura registrada foi de { tempMax } graus e ocorreu no dia { diaMax }");
            Console.WriteLine($"A menor temperatura registrada foi de { tempMin } graus e ocorreu no dia { diaMin }");
            Console.ReadLine();

        }
    }
}
