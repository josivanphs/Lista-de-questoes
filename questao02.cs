public class Equacao2Grau {
    private double a;
    private double b;
    private double c;

    public Equacao2Grau(double a, double b, double c) {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double Delta() {
        return b * b - 4 * a * c;
    }

    public double Raiz1() {
        double delta = Delta();
        if (delta >= 0) {
            return (-b + Math.Sqrt(delta)) / (2 * a);
        } else {
            return double.NaN;
        }
    }

    public double Raiz2() {
        double delta = Delta();
        if (delta >= 0) {
            return (-b - Math.Sqrt(delta)) / (2 * a);
        } else {
            return double.NaN;
        }
    }
}

