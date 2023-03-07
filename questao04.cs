public class Empregado {
    private string primeiroNome;
    private string sobrenome;
    private double salarioMensal;

    public Empregado(string primeiroNome, string sobrenome, double salarioMensal) {
        this.primeiroNome = primeiroNome;
        this.sobrenome = sobrenome;
        this.salarioMensal = salarioMensal > 0 ? salarioMensal : 0.0;
    }

