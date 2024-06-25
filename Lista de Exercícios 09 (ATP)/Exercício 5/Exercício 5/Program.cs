using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, endereco, telefone;
            Clientes[] clientes = new Clientes[10];

            for (int i = 0; i < clientes.Length; i++)
            {
                Console.WriteLine($"Informe os dados do {i + 1}º Cliente: \n");
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Endereço: ");
                endereco = Console.ReadLine();
                Console.Write("Telefone: ");
                telefone = Console.ReadLine();
                clientes[i] = new Clientes(nome, endereco, telefone);
                Console.WriteLine();
            }

            clientes[0].Nome = "Fulano";

            for (int i = 0;i < clientes.Length; i++)
            {
                Console.WriteLine($"{i + 1}º Cliente: \n");
                Console.WriteLine(clientes[i]);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}