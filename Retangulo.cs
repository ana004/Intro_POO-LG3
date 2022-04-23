public class Retangulo
{
    public double Base { get; set; }
    public double Altura { get; set; }
    public double Area { get => Base*Altura; }
    public double Perimetro { get => (2*Base)+(2*Altura); }

    public Retangulo(double Base, double Altura)
    {
        this.Base = Base;
        this.Altura = Altura;
    }
}