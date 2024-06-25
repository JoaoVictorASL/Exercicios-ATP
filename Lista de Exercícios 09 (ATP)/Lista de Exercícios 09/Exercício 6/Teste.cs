using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_6
{
    internal class Teste
    {
        static void Main(string[] args)
        {
            Cargo cargo1 = new Cargo(1, 50.0);
            Cargo cargo2 = new Cargo(2, 75.0);
            Cargo cargo3 = new Cargo(3, 100.0);

            Funcionario funcionario1 = new Funcionario(cargo1, 'M', 160);
            Funcionario funcionario2 = new Funcionario(cargo2, 'F', 170);
            Funcionario funcionario3 = new Funcionario(cargo3, 'M', 180);

            Console.WriteLine("Salário do funcionário 1: " + funcionario1.CalcularSalarioFinal());
            Console.WriteLine("Salário do funcionário 2: " + funcionario2.CalcularSalarioFinal());
            Console.WriteLine("Salário do funcionário 3: " + funcionario3.CalcularSalarioFinal());
        }
    }

    internal class Funcionario
    {
        private Cargo cargo;
        private char sexo;
        private double quantidadeHorasTrabalhadas;

        public Funcionario(Cargo cargo, char sexo, double quantidadeHorasTrabalhadas)
        {
            this.cargo = cargo;
            this.sexo = sexo;
            this.quantidadeHorasTrabalhadas = quantidadeHorasTrabalhadas;
        }

        public double CalcularSalarioFinal()
        {
            return cargo.GetValorHoraTrabalhada() * quantidadeHorasTrabalhadas;
        }
    }

    internal class Cargo
    {
        private int codigoDoCargo;
        private double valorHoraTrabalhada;

        public Cargo(int codigoDoCargo, double valorHoraTrabalhada)
        {
            this.codigoDoCargo = codigoDoCargo;
            this.valorHoraTrabalhada = valorHoraTrabalhada;
        }

        public double GetValorHoraTrabalhada()
        {
            return valorHoraTrabalhada;
        }
    }
}
