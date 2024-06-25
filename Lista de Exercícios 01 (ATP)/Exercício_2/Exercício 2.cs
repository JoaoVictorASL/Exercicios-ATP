using System;

class Exercício_2
{
    static void Main(string[] args)
    {
        double b, h, perimetro, area, diagonal;
        Console.WriteLine("informe a Base");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("informe a Altura");
        h = double.Parse(Console.ReadLine());

        perimetro = 2 * (b + h);
        area = b * h;
        diagonal = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2));

        Console.WriteLine("Perímetro do retângulo:" + perimetro);
        Console.WriteLine("Área do retângulo:" + area);
        Console.WriteLine("Diagonal do retângulo:" + diagonal);
        Console.ReadLine();
    }
}
