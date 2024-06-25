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
            int  voto, voto1, voto2, voto3, votonulo, votobranco;
            char opcao;

            voto1 = 0;
            voto2 = 0;
            voto3 = 0;
            votonulo = 0;
            votobranco = 0;

            do
            {
                Console.WriteLine("Informe um voto:");
                Console.WriteLine();

                Console.WriteLine("1 - Candidato 1");
                Console.WriteLine("2 - Candidato 2");
                Console.WriteLine("3 - Candidato 3");
                Console.WriteLine("4 - Voto em Branco");
                Console.WriteLine("5 - Voto Nulo");
                Console.WriteLine();

                voto = int.Parse(Console.ReadLine());

                if (voto == 1)
                    voto1++;

                else if (voto == 2)
                    voto2++;

                else if (voto == 3)
                    voto3++;

                else if (voto == 4)
                    votobranco++;

                else if (voto == 5)
                    votonulo++;

                Console.WriteLine();
                Console.WriteLine("Deseja informar mais um voto?");
                Console.WriteLine("S ou N");
                Console.WriteLine();
                opcao = char.Parse(Console.ReadLine());
            }

            while (opcao == 's' || opcao == 'S');

            Console.WriteLine();
            Console.WriteLine($"O Candidato 1 teve um total de {voto1} votos ");
            Console.WriteLine($"O Candidato 2 teve um total de {voto2} votos ");
            Console.WriteLine($"O Candidato 3 teve um total de {voto3} votos ");

            if (voto1 > voto2 && voto1 > voto3)
                Console.WriteLine($"O mais votado foi o Canditado 1 com um total de {voto1} votos");

            else if (voto2 > voto1 && voto2 > voto3)
                Console.WriteLine($"O mais votado foi o Canditado 2 com um total de {voto2} votos");

            else Console.WriteLine($"O mais votado foi o Canditado 3 com um total de {voto3} votos");

            Console.WriteLine($"No total tiveram {votonulo} votos nulos e {votobranco} votos em branco");
            Console.ReadLine(); 








        }
    }
}
