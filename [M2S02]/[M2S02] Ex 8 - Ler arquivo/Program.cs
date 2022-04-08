// 8 - Faça um programa que leia o arquivo notas.json na raiz do projeto e retorne o nome
// dos usuários que tiveram a média menor que 5.

using Newtonsoft.Json;

class Exercicio08
{
    public static void Main(string[] args)
    {
        string caminhoArquivoDeLeitura = @"../../../notas.json";
        string textoJson = File.ReadAllText(caminhoArquivoDeLeitura);

        List<Aluno> alunos = JsonConvert.DeserializeObject<List<Aluno>>(textoJson);

        Console.WriteLine("Alunos com média menor que 5:");
        alunos.ForEach(aluno =>
        {
            if (aluno.Media < 5)
            {
                Console.WriteLine($">>> A média da {aluno.Nome} foi {aluno.Media}");
            }
        });
    }
}

class Aluno
{
    public string Nome { get; }
    public int Media { get; }

    public Aluno(string nome, int media)
    {
        Nome = nome;
        Media = media;
    }
}
