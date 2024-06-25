using System;

    class Exercício_1
    {
        static void Main(string[] args)
        {
            double l, perimetro, area, diagonal;
            Console.WriteLine("Informe o Lado:");
            l = double.Parse(Console.ReadLine());

            perimetro = (4 * l);
            area = Math.Pow(l, 2);
            diagonal = l * Math.Sqrt(2);

            Console.WriteLine("O Perímetro do quadrado:" + perimetro);
            Console.WriteLine("A Área do quadrado:" + area);
            Console.WriteLine("A diagonal do quadrado:" + diagonal);
        
            Console.ReadLine();


        }
    }