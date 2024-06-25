using System;

class Program
{
    static void Main(string[] args)
    {
        int vagaOcupada;
        Estacionamento e = new Estacionamento("Estacionamento", 10);

        vagaOcupada = e.Estacionar("HKT0098");
        vagaOcupada = e.Estacionar("OLP4290");
        vagaOcupada = e.Estacionar("HJB0495");
        vagaOcupada = e.Estacionar("OWB3904");

        Console.WriteLine("Ocupação após a chegada de quatro clientes:");
        e.ExibirOcupacao();

        vagaOcupada = e.ObterVagaOcupada("HKT0098");
        Console.WriteLine($"Veículo HKT0098 está na vaga {vagaOcupada}");

        e.RetirarVeiculo("HKT0098");
        Console.WriteLine("Após a retirada do veículo de placa HKT0098:");
        e.ExibirOcupacao();

        vagaOcupada = e.Estacionar("HTP5619");
        vagaOcupada = e.Estacionar("BOL4861");
        vagaOcupada = e.Estacionar("HGT9436");

        Console.WriteLine("Ocupação após a chegada de mais 3 clientes:");
        e.ExibirOcupacao();

        Console.WriteLine($"Vagas livres: {e.ObterNumVagasLivres()}");

        Console.ReadLine();
    }
}
