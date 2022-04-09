namespace GestaoDeEmpresasApp.Core.Entities;

public abstract class Funcionario
{
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string Email { get; set; }
    public Departamento Departamento { get; set; }
    public Cargo Cargo { get; set; }

    protected Funcionario(string nome, string sobrenome, string email, Departamento departamento)
    {
        Nome = nome;
        Sobrenome = sobrenome;
        Email = email;
        Departamento = departamento;
    }
}