using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_exercícios_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade1, idade2, idade3;

            Console.WriteLine("Informe uma idade:");
            idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe uma segunda idade:");
            idade2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe uma terceira idade:");
            idade3 = int.Parse(Console.ReadLine());

            if (idade1 <= idade2 && idade1 <= idade3)
                Console.WriteLine("A menor idade é:" + idade1);

            else if (idade2 <= idade1 && idade2 <= idade3)
                Console.WriteLine("A menor idade é:" + idade2);

            else if (idade3 <= idade1 && idade3 <= idade2)
                Console.WriteLine("A menor idade é:" + idade3);

            if (idade1 >= idade2 && idade1 >= idade3)
                Console.WriteLine("A maior idade é:" + idade1);

            else if (idade2 >= idade1 && idade2 >= idade3)
                Console.WriteLine("A maior idade é:" + idade2);

            else if (idade3 >= idade1 && idade3 >= idade2)
                Console.WriteLine("A maior idade é:" + idade3);

            Console.ReadLine();


        }
    }
}
