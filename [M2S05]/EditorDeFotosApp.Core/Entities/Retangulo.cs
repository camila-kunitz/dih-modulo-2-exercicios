namespace EditorDeFotosApp.Core.Entities;

public class Retangulo : FiguraGeometrica
{
    public double Altura { get; }
    public double Largura { get; }

    public Retangulo(double altura, double largura)
    {
        Altura = altura;
        Largura = largura;
    }

    public override double GetArea()
    {
        return Altura * Largura;
    }
}