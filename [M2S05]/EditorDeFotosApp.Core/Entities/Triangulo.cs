namespace EditorDeFotosApp.Core.Entities;

public class Triangulo : FiguraGeometrica
{
    public double Base { get; }
    public double Altura { get; }

    public Triangulo(double @base, double altura)
    {
        Base = @base;
        Altura = altura;
    }
    
    public override double GetArea()
    {
        return (Base * Altura) / 2;
    }
}