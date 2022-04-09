namespace AnimaisApp.Core.Entities
{
    public class Cachorro : Animal
    {
        public Cachorro(string nome, string idade, string peso, string altura) : base(nome, idade, peso, altura)
        {
            Especie = Especie.CANINO;
        }
    }
}
