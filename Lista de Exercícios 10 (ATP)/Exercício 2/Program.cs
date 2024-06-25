<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercício_2
{
    class Program
    {
        static void Pesos(StreamReader arq)
        {
            double maiorPeso = double.MinValue, 
                   menorPeso = double.MaxValue, 
                   somaPeso = 0,
                   mediaPeso;

            string[] vet;
            string linha;

            linha = arq.ReadLine();

            while(linha != null)
            {
                vet = linha.Split(';');

                if (double.Parse(vet[3]) > maiorPeso)
                {
                    maiorPeso = double.Parse(vet[3]);
                }

                if (double.Parse(vet[3]) < menorPeso)
                {
                    menorPeso = double.Parse(vet[3]);
                }

                somaPeso += double.Parse(vet[3]);
                linha = arq.ReadLine();
            }

            mediaPeso = somaPeso / 9;

            Console.WriteLine("Média dos Pesos: " + Math.Round(mediaPeso, 2));
            Console.WriteLine("Maior Peso: " + maiorPeso);
            Console.WriteLine("Menor Peso: " + menorPeso);


        }
        static void Main(string[] args)
        {
            try
            {
                StreamReader arq = new StreamReader("arquivo-01.txt", Encoding.UTF8);
                Pesos(arq);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

   
            Console.ReadLine();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercício_2
{
    class Program
    {
        static void Pesos(StreamReader arq)
        {
            double maiorPeso = double.MinValue, 
                   menorPeso = double.MaxValue, 
                   somaPeso = 0,
                   mediaPeso;

            string[] vet;
            string linha;

            linha = arq.ReadLine();

            while(linha != null)
            {
                vet = linha.Split(';');

                if (double.Parse(vet[3]) > maiorPeso)
                {
                    maiorPeso = double.Parse(vet[3]);
                }

                if (double.Parse(vet[3]) < menorPeso)
                {
                    menorPeso = double.Parse(vet[3]);
                }

                somaPeso += double.Parse(vet[3]);
                linha = arq.ReadLine();
            }

            mediaPeso = somaPeso / 9;

            Console.WriteLine("Média dos Pesos: " + Math.Round(mediaPeso, 2));
            Console.WriteLine("Maior Peso: " + maiorPeso);
            Console.WriteLine("Menor Peso: " + menorPeso);


        }
        static void Main(string[] args)
        {
            try
            {
                StreamReader arq = new StreamReader("arquivo-01.txt", Encoding.UTF8);
                Pesos(arq);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

   
            Console.ReadLine();
        }
    }
}
>>>>>>> a7f6e8a64b8880b072dc6346c4c989f763a61dcf
