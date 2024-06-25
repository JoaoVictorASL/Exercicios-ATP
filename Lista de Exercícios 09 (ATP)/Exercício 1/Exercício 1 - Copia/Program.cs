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

            Console.WriteLine("Informe o nome do 1º cliente");
            nome = Console.ReadLine();
            Console.WriteLine("Informe endereço do 1º cliente");
            endereco = Console.ReadLine();
            Console.WriteLine("Informe o telefone do 1º cliente");
            telefone = Console.ReadLine();
            Clientes c1 = new Clientes(nome, endereco, telefone);

            Console.WriteLine("Informe o nome do 2º cliente");
            nome = Console.ReadLine();
            Console.WriteLine("Informe endereço do 2º cliente");
            endereco = Console.ReadLine();
            Console.WriteLine("Informe o telefone do 2º cliente");
            telefone = Console.ReadLine();
            Clientes c2 = new Clientes(nome, endereco, telefone);

            Console.WriteLine("Informe o nome do 3º cliente");
            nome = Console.ReadLine();
            Console.WriteLine("Informe o telefone do 3º cliente");
            telefone = Console.ReadLine();
            Clientes c3 = new Clientes(nome, telefone);

            Console.WriteLine("\nDados dos clientes cadastrados:");
            Console.WriteLine($"Cliente 1: Nome = {c1.Nome}, Endereço = {c1.Endereco}, Telefone = {c1.Telefone}");
            Console.WriteLine($"Cliente 2: Nome = {c2.Nome}, Endereço = {c2.Endereco}, Telefone = {c2.Telefone}");
            Console.WriteLine($"Cliente 3: Nome = {c3.Nome}, Endereço = {c3.Endereco}, Telefone = {c3.Telefone}");

            Console.ReadLine();
        }
    }
}