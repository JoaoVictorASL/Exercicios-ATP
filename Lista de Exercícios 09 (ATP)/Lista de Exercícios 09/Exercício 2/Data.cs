using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    internal class Data
    {
        private string dia;
        private string mes;
        private string ano;

        public Data (string dia, string mes, string ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }

        public string Dia
        {
            get { return dia; }
            set { dia = value; }
        }

        public string Mes
        {
            get { return mes; }
            set { mes = value; }
        }

        public string Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public override string ToString()
        {
            return $"{dia}/{mes}/{ano}";
        }

    }
}
