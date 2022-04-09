namespace GestaoDeEmpresasApp.Core.Entities;

public class Comprador : Funcionario
{
    public Comprador(string nome, string sobrenome, string email, Departamento departamento) : base(nome, sobrenome, email, departamento)
    {
        Cargo = Cargo.COMPRADOR;
    }
}