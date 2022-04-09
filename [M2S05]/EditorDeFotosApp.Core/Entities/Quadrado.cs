namespace EditorDeFotosApp.Core.Entities;

public class Quadrado : FiguraGeometrica
{
    public double Lado { get; }

    public Quadrado(double lado)
    {
        Lado = lado;
    }
    
    public override double GetArea()
    {
        return Lado * Lado;
    }
}