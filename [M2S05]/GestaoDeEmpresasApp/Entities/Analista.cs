namespace GestaoDeEmpresasApp.Core.Entities;

public class Analista : Funcionario
{
    public Analista(string nome, string sobrenome, string email, Departamento departamento) : base(nome, sobrenome, email, departamento)
    {
        Cargo = Cargo.ANALISTA_DE_SISTEMAS;
    }
}