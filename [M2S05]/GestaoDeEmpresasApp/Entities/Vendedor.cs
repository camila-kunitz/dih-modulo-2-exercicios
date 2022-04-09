namespace GestaoDeEmpresasApp.Core.Entities;

public class Vendedor : Funcionario
{
    public Vendedor(string nome, string sobrenome, string email, Departamento departamento) : base(nome, sobrenome, email, departamento)
    {
        Cargo = Cargo.VENDEDOR;
    }
}