// Faça um programa que leia o arquivo notas.json e salve um arquivo reprovados.json apenas com os alunos reprovados.

using Newtonsoft.Json;

class Exercicio09
{
    public static void Main(string[] args)
    {
        string caminhoArquivoDeEscrita = @"../../../reprovados.txt";
        string caminhoArquivoDeLeitura = @"../../../notas.json";
        string textoJson = File.ReadAllText(caminhoArquivoDeLeitura);

        List<Aluno> alunos = JsonConvert.DeserializeObject<List<Aluno>>(textoJson);
        List<Aluno> alunosAbaixoDaMedia = alunos.Where(aluno => aluno.Media < 5).ToList();

        StreamWriter writer = File.CreateText(caminhoArquivoDeEscrita);
        alunosAbaixoDaMedia.ForEach(reprovado => writer.WriteLine($"Aluno(a) {reprovado.Nome} com média {reprovado.Media} foi reprovado(a)."));
        writer.Close();
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