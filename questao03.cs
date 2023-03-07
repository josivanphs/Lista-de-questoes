public class Invoice {
    private int numero;
    private string descricao;
    private int quantidade;
    private double precoUnitario;

    public Invoice(int numero, string descricao, int quantidade, double precoUnitario) {
        this.numero = numero;
        this.descricao = descricao;
        this.quantidade = quantidade > 0 ? quantidade : 0;
        this.precoUnitario = precoUnitario > 0 ? precoUnitario : 0.0;
    }

    public int Numero {
        get { return numero; }
        set { numero = value; }
    }

    public string Descricao {
        get { return descricao; }
        set { descricao = value; }
    }

    public int Quantidade {
        get { return quantidade; }
        set { quantidade = value > 0 ? value : 0; }
    }

    public double PrecoUnitario {
        get { return precoUnitario; }
        set { precoUnitario = value > 0 ? value : 0.0; }
    }

    public double GetInvoiceAmount() {
        return quantidade * precoUnitario;
    }
}
