namespace AnimaisApp.Core.Entities
{
    public class Cavalo : Animal
    {
        public Cavalo(string nome, string idade, string peso, string altura) : base(nome, idade, peso, altura)
        {
            Especie = Especie.EQUINO;
        }
    }
}
