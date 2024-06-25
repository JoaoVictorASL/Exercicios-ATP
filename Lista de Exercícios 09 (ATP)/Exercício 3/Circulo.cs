using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_3
{
    internal class Circulo
    {
        private double raio;

        public Circulo (double raio)
        {
            this.raio = raio;
        }   

        public double Raio
        {
            get { return raio; }
            set { raio = value; }
        }

        public double CalcularArea()
        {
            double area;

            area = Math.PI * Math.Pow(raio, 2);
            return area;
        }

        public double CalcularDiametro()
        {
            double diametro;

            diametro = raio * 2;
            return diametro;
        }

        public double CalcularPerimetro()
        {
            double perimetro;

            perimetro = 2 * Math.PI * raio;
            return perimetro;
        }
    }
}
