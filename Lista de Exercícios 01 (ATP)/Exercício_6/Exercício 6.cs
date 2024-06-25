using System;
using System.Xml.XPath;

class Exercício_6
{
    static void Main(string[] args)
    {
        double numerador, denominador, resultado;

        Console.WriteLine("Informe o numerador da fração:");
        numerador = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe o denominador da fração:");
        denominador = double.Parse(Console.ReadLine());

        resultado = numerador / denominador;

        Console.WriteLine("Resultado da fração:" + resultado.ToString("N2"));
        Console.ReadLine();
    }
}
      

