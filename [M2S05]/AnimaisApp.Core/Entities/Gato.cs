namespace AnimaisApp.Core.Entities
{
    public class Gato : Animal
    {
        public Gato(string nome, string idade, string peso, string altura) : base(nome, idade, peso, altura)
        {
            Especie = Especie.FELINO;
        }
    }
}
