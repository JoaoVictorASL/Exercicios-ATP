using System;

class Estacionamento
{
    private string nome; 
    private int numTotalVagas; 
    private int numVagasLivres; 
    private string[] vagas; 
    public Estacionamento(string nome, int numTotalVagas)
    {
        this.nome = nome;
        this.numTotalVagas = numTotalVagas;
        this.numVagasLivres = numTotalVagas;
        this.vagas = new string[numTotalVagas];
    }

    public int Estacionar(string placa)
    {
        if (numVagasLivres == 0)
        {
            return -1;
        }

        for (int i = 0; i < vagas.Length; i++)
        {
            if (vagas[i] == null)
            {
                vagas[i] = placa;
                numVagasLivres--;
                return i;
            }
        }

        return -1; 
    }

    public int ObterVagaOcupada(string placa)
    {
        for (int i = 0; i < vagas.Length; i++)
        {
            if (vagas[i] == placa)
            {
                return i;
            }
        }
        return -1; 
    }

    public void RetirarVeiculo(string placa)
    {
        for (int i = 0; i < vagas.Length; i++)
        {
            if (vagas[i] == placa)
            {
                vagas[i] = null;
                numVagasLivres++;
                break;
            }
        }
    }

    public int ObterNumVagasLivres()
    {
        return numVagasLivres;
    }

    public void ExibirOcupacao()
    {
        for (int i = 0; i < vagas.Length; i++)
        {
            if (vagas[i] == null)
            {
                Console.WriteLine($"Vaga {i}: vazia");
            }
            else
            {
                Console.WriteLine($"Vaga {i}: {vagas[i]}");
            }
        }
    }
}
