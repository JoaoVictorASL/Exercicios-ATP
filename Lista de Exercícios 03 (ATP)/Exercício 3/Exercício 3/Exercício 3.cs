using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade, totalpessoas, percent1, percent2, percent3, percent4, percent5, fx1, fx2, fx3, fx4, fx5;

            totalpessoas = 0;
            fx1 = 0; fx2 = 0; fx3 = 0; fx4 = 0; fx5 = 0; 

            Console.WriteLine("Informe a idade:");
            idade = int.Parse(Console.ReadLine());

            while (idade > -1)
            {

                totalpessoas++;

                if (idade >= 1 & idade <=15)
                {
                    fx1++;
                }

                else if (idade >= 16 & idade <= 30)
                {
                    fx2++;
                }

                else if (idade >= 31 & idade <= 45)
                {
                    fx3++;
                }
                
                else if (idade >= 46 & idade <= 60)
                {
                    fx4++;
                }

                else if (idade >= 61)
                {
                    fx5++;
                }


                Console.WriteLine("Informe a idade:");
                idade = int.Parse(Console.ReadLine());

            }

            percent1 = (fx1 / totalpessoas) * 100;
            percent2 = (fx2 / totalpessoas) * 100;
            percent3 = (fx3 / totalpessoas) * 100;
            percent4 = (fx4 / totalpessoas) * 100;
            percent5 = (fx5 / totalpessoas) * 100;



            Console.WriteLine("TOTALPESSOAS:" + totalpessoas);

            Console.WriteLine("Pessoas entre 1 e 15 anos:" + fx1);
            Console.WriteLine("Porcentagem de pessoas dessa faixa etária:" + percent1);
            Console.WriteLine("Pessoas entre 16 e 30 anos:" + fx2);
            Console.WriteLine("Porcentagem de pessoas dessa faixa etária:" + percent2);
            Console.WriteLine("Pessoas entre 31 e 45 anos:" + fx3);
            Console.WriteLine("Porcentagem de pessoas dessa faixa etária:" + percent3);
            Console.WriteLine("Pessoas entre 46 e 60 anos:" + fx4);
            Console.WriteLine("Porcentagem de pessoas dessa faixa etária:" + percent4);
            Console.WriteLine("Pessoas com 61 anos ou mais:" + fx5);
            Console.WriteLine("Porcentagem de pessoas dessa faixa etária:" + percent5);

            Console.ReadLine();

        }
    }
}
