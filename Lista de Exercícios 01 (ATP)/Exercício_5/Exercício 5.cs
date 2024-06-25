using System;

    class Exercício_5
    {
        static void Main(string[] args)
        {
        double varA, varB;

        Console.WriteLine("Informe a variável A:");
        varA = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe a variável B:");
        varB = double.Parse(Console.ReadLine());

        double varA2, varB2;

        varA2 = varB;
        varB2 = varA;

        varA = varA2;
        varB = varB2;

        Console.WriteLine("Valor final da variável A:" + varA);
        Console.WriteLine("Valor final da variável B:" + varB);]
        Console.ReadLine();
        }
    }
