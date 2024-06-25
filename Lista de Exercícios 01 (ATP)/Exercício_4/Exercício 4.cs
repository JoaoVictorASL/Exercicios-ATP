using System;

    class Exercício_4
    {
        static void Main(string[] args)
        {
            int eleitores, vb, vn, vv;
            double percentualvb, percentualvn, percentualvv;

            Console.WriteLine("Informe a quantidade total de eleitores:");
            eleitores = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade total de votos brancos:");
            vbrancos = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade total de votos nulos:");
            vnulos = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade total de votos válidos:");
            vvalidos = int.Parse(Console.ReadLine());

            percentualvb = vb / eleitores * 100;
            percentualvn = vn / eleitores * 100;
            percentualvv = vv / eleitores * 100;

            Console.WriteLine("Percentual de votos brancos:" + percentualvb);
            Console.WriteLine("Percentual de votos nulos:" + percentualvn);
            Console.WriteLine("A Percentual de votos válidos:" + percentualvv);
            Console.ReadLine();

        }
    }
