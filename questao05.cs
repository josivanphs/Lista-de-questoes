public class Conta {
    private int numeroConta;
    private string nomeTitular;
    private double saldo;

    public Conta(int numeroConta, string nomeTitular, double saldoInicial) {
        this.numeroConta = numeroConta;
        this.nomeTitular = nomeTitular;
        this.saldo = saldoInicial;
    }

    public void Saldo() {
        Console.WriteLine("Saldo atual da conta: R$ " + saldo.ToString("F2"));
    }

    public void Deposito(double valor) {
        saldo += valor;
        Console.WriteLine("Depósito de R$ " + valor.ToString("F2") + " realizado com sucesso. Novo saldo: R$ " + saldo.ToString("F2"));
    }

    public void Saque(double valor) {
        if (saldo >= valor) {
            saldo -= valor;
            Console.WriteLine("Saque de R$ " + valor.ToString("F2") + " realizado com sucesso. Novo saldo: R$ " + saldo.ToString("F2"));
        } else {
            Console.WriteLine("Saldo insuficiente para realizar o saque.");
        }
    }
}
