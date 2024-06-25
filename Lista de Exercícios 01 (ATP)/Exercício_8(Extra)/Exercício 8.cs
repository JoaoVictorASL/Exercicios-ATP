using System;
    class Exercício_8_Extra
    {
        static void Main(string[] args)
        {
        int num, digitocentena, digitodezena, digitounidade, numinvertido;

        Console.WriteLine("Digite um número inteiro com 3 digitos:");
        num = int.Parse(Console.ReadLine());

        digitocentena = num / 100;
        digitodezena = (num / 10) % 10;
        digitounidade = num % 10;

        numinvertido = digitounidade * 100 + digitodezena * 10 + digitocentena;

        Console.WriteLine("O número invertido é:" + numinvertido);
        Console.ReadLine();
        }
    }
