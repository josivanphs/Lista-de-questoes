
public class Aluno {
    private int matricula;
    private string nome;
    private double nota1;
    private double nota2;
    private double trabalho;

    public Aluno(int matricula, string nome, double nota1, double nota2, double trabalho) {
        this.matricula = matricula;
        this.nome = nome;
        this.nota1 = nota1;
        this.nota2 = nota2;
        this.trabalho = trabalho;
    }

    public double Media() {
        return (nota1 * 2.5 + nota2 * 2.5 + trabalho * 2) / 7;
    }

    public double Final() {
        double media = Media();
        if (media >= 6.0) {
            return 0.0;
        } else {
            return Math.Ceiling((12.0 - media) / 2.0);
        }
    }
}