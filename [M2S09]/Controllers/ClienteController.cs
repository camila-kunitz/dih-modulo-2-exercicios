using ClinicaVeterinaria.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaVeterinaria.Controllers
{
    [Route("api/cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        /// <summary>
        /// Retorna lista de Clientes.
        /// </summary>
        /// <returns>Retorna uma lista dos clientes cadastrados.</returns>
        /// <response code="200">Retorno da lista de Clientes.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a consulta.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IEnumerable<Cliente> Listar()
        {
            return new List<Cliente> {
                new Cliente { Id = 1, Nome= "João" },
                new Cliente { Id = 2, Nome= "Maria" }
            };
        }

        /// <summary>
        /// Retorna um Cliente.
        /// </summary>
        /// <param name="id">Representa o Id do Cliente</param>
        /// <returns>Retorna o resultado do Cliente consultado.</returns>
        /// <response code="200">Retorno do Cliente consultado.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a consulta.</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Cliente Consultar(int id)
        {
            return new Cliente { Id = 1, Nome = "João" };
        }

        /// <summary>
        /// Cadastra um Cliente.
        /// </summary>
        /// <returns>Retorna o resultado do Cliente cadastrado.</returns>
        /// <response code="200">Retorno do Cliente cadastrado.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a consulta.</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Cliente Criar([FromBody] Cliente cliente)
        {
            return new Cliente { Id = cliente.Id, Nome = cliente.Nome, Endereco = cliente.Endereco, Bairro = cliente.Bairro, CEP = cliente.CEP, Cidade = cliente.Cidade, Estado = cliente.Estado, Telefone = cliente.Telefone };
        }

        /// <summary>
        /// Atualiza um Cliente.
        /// </summary>
        /// <param name="id">Representa o Id do Cliente</param>
        /// <returns>Retorna o resultado do Cliente atualizado.</returns>
        /// <response code="200">Retorno do Cliente atualizado.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a consulta.</response>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Cliente Atualizar(int id, [FromBody] Cliente cliente)
        {
            return new Cliente { Id = id, Nome = cliente.Nome, Endereco = cliente.Endereco, Bairro = cliente.Bairro, CEP = cliente.CEP, Cidade = cliente.Cidade, Estado = cliente.Estado, Telefone = cliente.Telefone };
        }

        /// <summary>
        /// Exclui um Cliente.
        /// </summary>
        /// <param name="id">Representa o Id do Cliente</param>
        /// <response code="200">Cliente excluído com sucesso</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a consulta.</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public void Deletar(int id)
        {
        }
    }
}
