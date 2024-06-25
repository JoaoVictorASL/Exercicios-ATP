using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, email, primeiroNome, sobrenome;
            int divisao1, divisao2;

            Console.WriteLine("Informe o nome completo: \n");
            nome = Console.ReadLine();
            nome = nome.ToLower();

            divisao1 = nome.IndexOf(" ");
            divisao2 = nome.LastIndexOf(" ");

            primeiroNome = nome.Substring(0, divisao1);
            sobrenome = nome.Substring(divisao2 + 1);

            email = $"{primeiroNome}.{sobrenome}@acme.br";

            Console.WriteLine("\nEmail: " + email);
            Console.ReadLine();
        }
    }
}
