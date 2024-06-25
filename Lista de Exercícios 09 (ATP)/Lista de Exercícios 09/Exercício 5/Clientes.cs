using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    internal class Clientes
    {
        private string nome;
        private string endereco;
        private string telefone;

        public Clientes(string nome, string endereco, string telefone)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.telefone = telefone;
        }

        public Clientes(string nome, string telefone)
        {
            this.nome = nome;
            this.endereco = string.Empty;
            this.telefone = telefone;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public override string ToString()
        {
            return $"Nome: {nome}\n" +
                   $"Endereço: {endereco}\n" +
                   $"Telefone: {telefone}";
        }
    }
}

