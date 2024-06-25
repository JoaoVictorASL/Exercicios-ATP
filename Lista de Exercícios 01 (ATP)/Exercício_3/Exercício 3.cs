using System;
    class Exercício_3
{
    static void Main(string[] args)
    {
        int f, c;
        Console.WriteLine("informe a temperatura:");
        f = int.Parse(Console.ReadLine());

        c = 5 * (f - 32) / 9;

        Console.Write("A temperatura em graus celsius é:" + c);
        Console.ReadLine();
    }
}
