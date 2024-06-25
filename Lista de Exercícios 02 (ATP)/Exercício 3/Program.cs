using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, tempo;
            char habilitacao;

            Console.WriteLine("Informe sua idade:");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o tipo de Habilitação que você possui:");
            habilitacao = char.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quanto anos você possui sua Carteira de Habilitação:");
            tempo = int.Parse(Console.ReadLine());

            if (idade >= 21 && tempo >= 2 && habilitacao == 'B')
                Console.WriteLine("Você possui os requisitos necessários para tirar a Habilitação do tipo D");

            else if (idade <= 21 && tempo >= 2 && habilitacao == 'B')
                Console.WriteLine("Você não possui a idade necessária para tirar a Habilitação do tipo D");

            else if (idade >= 21 && tempo <= 2 && habilitacao == 'B')
                Console.WriteLine("Você não possui o tempo necessário para tirar a Habilitação do tipo D");

            if (idade >= 21 && tempo >= 1 && habilitacao == 'C')
                Console.WriteLine("Você possui os requisitos necessários para tirar a Habilitação do tipo D");

            else if (idade <= 21 && tempo >= 1 && habilitacao == 'C')
                Console.WriteLine("Você não possui a idade necessária para tirar a Habilitação do tipo D");

            else if (idade >= 21 && tempo <= 1 && habilitacao == 'C')
                Console.WriteLine("Você possui o tempo necessário para tirar a Habilitação do tipo D");

            Console.ReadLine();





        }
    }
}
