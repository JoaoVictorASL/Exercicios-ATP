using System;

    class Exercício_9_Extra
    {
        static void Main(string[] args)
        {
        double salario, quantkilowatt, valorkilowatt, valoraserpago;

        Console.WriteLine("Informe o valor da salário mínimo em reais:");
        salario = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe a quantidade de kilowatt gasto por uma residência:");
        quantkilowatt = double.Parse(Console.ReadLine());

        //100 Kiowatt = 1/10 do salário mínimo

        valorkilowatt = salario / 1000;
        valoraserpago = quantkilowatt * valorkilowatt;

        Console.WriteLine("O valor em reais por cada kilowatt é:" + valorkilowatt);
        Console.WriteLine("O valor em reais a ser pago pela residência é de:" + valoraserpago);
        Console.ReadLine();
        }
    }

