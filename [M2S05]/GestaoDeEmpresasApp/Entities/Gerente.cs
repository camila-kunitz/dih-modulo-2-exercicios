namespace GestaoDeEmpresasApp.Core.Entities;

public class Gerente : Funcionario
{
    public Gerente(string nome, string sobrenome, string email, Departamento departamento) : base(nome, sobrenome, email, departamento)
    {
        Cargo = Cargo.GERENTE;
    }
}