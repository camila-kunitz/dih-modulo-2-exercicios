namespace AnimaisApp.Core.Entities
{
    public abstract class Animal
    {
        public string Nome { get; set; }
        public string Idade { get; set; }
        public string Peso { get; set; }
        public string Altura { get; set; }
        public Especie Especie { get; set; }

        public Animal(string nome, string idade, string peso, string altura)
        {
            Nome = nome;
            Idade = idade;
            Peso = peso;
            Altura = altura;
        }
    }
}
