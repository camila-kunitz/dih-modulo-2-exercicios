using ClinicaVeterinaria.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaVeterinaria.Controllers
{
    [Route("api/tratamento")]
    [ApiController]
    public class TratamentoController : ControllerBase
    {
        /// <summary>
        /// Retorna lista de Tratamentos.
        /// </summary>
        /// <returns>Retorna uma lista dos Tratamentos cadastrados.</returns>
        /// <response code="200">Retorno da lista de Tratamentos.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a consulta.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IEnumerable<Tratamento> Listar()
        {
            return new List<Tratamento> {
                new Tratamento { Id = 1 },
                new Tratamento { Id = 2 }
            };
        }

        /// <summary>
        /// Retorna um Tratamento.
        /// </summary>
        /// <param name="id">Representa o Id do Tratamento</param>
        /// <returns>Retorna o resultado do Tratamento consultado.</returns>
        /// <response code="200">Retorno do Tratamento consultado.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a consulta.</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Tratamento Consultar(int id)
        {
            return new Tratamento { Id = 1 };
        }

        /// <summary>
        /// Cadastra um Tratamento.
        /// </summary>
        /// <returns>Retorna o resultado do Tratamento cadastrado.</returns>
        /// <response code="200">Retorno do Tratamento cadastrado.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a consulta.</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Tratamento Criar([FromBody] Tratamento tratamento)
        {
            return new Tratamento { Id = 1 };
        }

        /// <summary>
        /// Atualiza um Tratamento.
        /// </summary>
        /// <param name="id">Representa o Id do Tratamento</param>
        /// <returns>Retorna o resultado do Tratamento atualizado.</returns>
        /// <response code="200">Retorno do Tratamento atualizado.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a consulta.</response>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Tratamento Atualizar(int id, [FromBody] Tratamento tratamento)
        {
            return new Tratamento { Id = 1 };
        }

        /// <summary>
        /// Exclui um Tratamento.
        /// </summary>
        /// <param name="id">Representa o Id do Tratamento</param>
        /// <response code="200">Tratamento excluído com sucesso</response>
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
