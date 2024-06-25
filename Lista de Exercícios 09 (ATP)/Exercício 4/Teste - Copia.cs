using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_4
{
    internal class Teste
    {
        static void Main(string[] args)
        {
            string nome;
            int matricula, i;
            double[] notas;

            Console.WriteLine("1º Aluno(a): \n");
            Console.Write("Informe o nome: ");
            nome = Console.ReadLine();
            Console.Write("Informe a matrícula: ");
            matricula = int.Parse(Console.ReadLine());

            notas = new double[10];
            Console.WriteLine("\nInforme as notas do Aluno(a): \n");
            for (i = 0; i < notas.Length; i++)
            {
                Console.Write($"{1 + i}º Nota: ");
                notas[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            Aluno aluno1 = new Aluno(nome, matricula, notas);

            Console.WriteLine("2º Aluno(a): \n");
            Console.Write("Informe o nome: ");
            nome = Console.ReadLine();
            Console.Write("Informe a matrícula: ");
            matricula = int.Parse(Console.ReadLine());

            notas = new double[10]; 
            Console.WriteLine("\nInforme as notas do Aluno(a): \n");
            for (i = 0; i < notas.Length; i++)
            {
                Console.Write($"{1 + i}º Nota: ");
                notas[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            Aluno aluno2 = new Aluno(nome, matricula, notas);

            Console.WriteLine($"1º Aluno: \n\nNome: {aluno1.Nome} \nMatrícula: {aluno1.Matricula} \nMédia das notas: {aluno1.MediaNota()}");
            Console.WriteLine($"\n2º Aluno: \n\nNome: {aluno2.Nome} \nMatrícula: {aluno2.Matricula} \nMédia das notas: {aluno2.MediaNota()}");
            Console.ReadLine();
        }
    }
}
