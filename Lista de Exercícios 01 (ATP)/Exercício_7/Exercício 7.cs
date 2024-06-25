using System;

class Execício_7
{
    static void Main(string[] args)
    {
        double despesa, percentualgorjeta, valorgorjeta, valortotal;

        Console.WriteLine("Informe a despesa realizada:");
        despesa = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe o percentual de gorjeta gasto:");
        percentualgorjeta = double.Parse(Console.ReadLine());

        valorgorjeta = percentualgorjeta * despesa;
        valortotal = despesa + valorgorjeta;

        Console.WriteLine("O valor da gorjeta:" + valorgorjeta);
        Console.WriteLine("O valor total a ser gasto" + valortotal);
        Console.ReadLine();
    }
}
