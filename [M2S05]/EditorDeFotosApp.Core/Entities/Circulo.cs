namespace EditorDeFotosApp.Core.Entities;

public class Circulo : FiguraGeometrica
{
    private double raio { get; }

    public Circulo(double raio)
    {
        this.raio = raio;
    }
    
    public override double GetArea()
    {
        return 3.14 * raio * raio;
    }
}