using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_7
{
    class Etiqueta
    {
        private string marca;
        private string tamanho;

        public Etiqueta(string marca, string tamanho)
        {
            this.marca = marca;
            this.tamanho = tamanho;
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }
    }

    class Produto
    {
        private string nome;
        private double preco;
        private Etiqueta etiqueta;

        public Produto(string nome, double preco, Etiqueta etiqueta)
        {
            this.nome = nome;
            this.preco = preco;
            this.etiqueta = etiqueta;
        }

        public Produto(string nome, double preco, string marca, string tamanho)
        {
            this.nome = nome;
            this.preco = preco;
            this.etiqueta = new Etiqueta(marca, tamanho);
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public Etiqueta Etiqueta
        {
            get { return etiqueta; }
            set { etiqueta = value; }
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Marca: {etiqueta.Marca}");
            Console.WriteLine($"Tamanho: {etiqueta.Tamanho}");
        }
    }

    class TesteProduto
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do primeiro produto:");
            string nome1 = Console.ReadLine();
            Console.WriteLine("Digite o preço do primeiro produto:");
            double preco1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a marca do primeiro produto:");
            string marca1 = Console.ReadLine();
            Console.WriteLine("Digite o tamanho do primeiro produto:");
            string tamanho1 = Console.ReadLine();

            Produto produto1 = new Produto(nome1, preco1, marca1, tamanho1);
            Console.WriteLine("\nDetalhes do primeiro produto:");
            produto1.ExibirDetalhes();

            Console.WriteLine("\nDigite o nome do segundo produto:");
            string nome2 = Console.ReadLine();
            Console.WriteLine("Digite o preço do segundo produto:");
            double preco2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a marca do segundo produto:");
            string marca2 = Console.ReadLine();
            Console.WriteLine("Digite o tamanho do segundo produto:");
            string tamanho2 = Console.ReadLine();

            Etiqueta etiqueta2 = new Etiqueta(marca2, tamanho2);
            Produto produto2 = new Produto(nome2, preco2, etiqueta2);
            Console.WriteLine("\nDetalhes do segundo produto:");
            produto2.ExibirDetalhes();

            Console.WriteLine("\nAlterando os campos do primeiro produto...");
            Console.WriteLine("Digite o novo nome do primeiro produto:");
            produto1.Nome = Console.ReadLine();
            Console.WriteLine("Digite o novo preço do primeiro produto:");
            produto1.Preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nova marca do primeiro produto:");
            produto1.Etiqueta.Marca = Console.ReadLine();
            Console.WriteLine("Digite o novo tamanho do primeiro produto:");
            produto1.Etiqueta.Tamanho = Console.ReadLine();

            Console.WriteLine("\nDetalhes do primeiro produto após alteração:");
            produto1.ExibirDetalhes();
        }
    }
}
