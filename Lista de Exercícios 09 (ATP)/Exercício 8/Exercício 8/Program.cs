using System;

class Cliente
{
    private string nome;
    private string cpf;
    private ContaCorrente conta;

    public Cliente(string nome, string cpf, ContaCorrente conta)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.conta = conta;
    }

    public string Nome { get { return nome; } }
    public string CPF { get { return CPF; } }
    public ContaCorrente Conta { get { return conta; } }
}

class ContaCorrente
{
    private int numero;
    private int digito;
    private Agencia agencia;
    private double saldo;

    public ContaCorrente(int numero, int digito, Agencia agencia, double saldoInicial)
    {
        this.numero = numero;
        this.digito = digito;
        this.agencia = agencia;
        this.saldo = saldoInicial;
    }

    public void Depositar(double valor)
    {
        saldo += valor;
    }

    public bool Sacar(double valor)
    {
        if (valor <= saldo)
        {
            saldo -= valor;
            return true;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para saque.");
            return false;
        }
    }

    public string ConsultarSaldo()
    {
        return $"Conta: {numero}-{digito}, Agencia: {agencia.Numero}-{agencia.Digito}, Saldo: R${saldo:F2}";
    }
}

class Agencia
{
    private string nome;
    private int numero;
    private int digito;

    public Agencia(string nome, int numero, int digito)
    {
        this.nome = nome;
        this.numero = numero;
        this.digito = digito;
    }

    public string Nome { get { return nome; } }
    public int Numero { get { return numero; } }
    public int Digito { get { return digito; } }
}

class CaixaEletronico
{
    static void Main(string[] args)
    {
        Agencia agencia = new Agencia("Pampulha", 7890, 5);
        ContaCorrente conta = new ContaCorrente(1234, 4, agencia, 150.00);
        Cliente cliente = new Cliente("Ademar da Silva", "123231518-12", conta);

        Console.WriteLine($"Cliente: {cliente.Nome}");
        Console.WriteLine($"CPF: {cliente.CPF}");

        // Operações
        Console.WriteLine("Saldo Inicial: " + cliente.Conta.ConsultarSaldo());
        bool saqueRealizado = cliente.Conta.Sacar(140.00);
        if (saqueRealizado)
        {
            Console.WriteLine("Saque de R$140,00 realizado com sucesso.");
        }
        Console.WriteLine("Saldo após saque: " + cliente.Conta.ConsultarSaldo());

        saqueRealizado = cliente.Conta.Sacar(200.00);
        if (!saqueRealizado)
        {
            Console.WriteLine("Tentativa de saque de R$200,00 não realizada devido a saldo insuficiente.");
        }
        Console.WriteLine("Saldo após tentativa de saque: " + cliente.Conta.ConsultarSaldo());

        cliente.Conta.Depositar(25.45);
        Console.WriteLine("Depósito de R$25,45 realizado.");
        Console.WriteLine("Saldo após depósito: " + cliente.Conta.ConsultarSaldo());
    }
}
