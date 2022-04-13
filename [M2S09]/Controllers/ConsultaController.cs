using ClinicaVeterinaria.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaVeterinaria.Controllers
{
    [Route("api/consulta")]
    [ApiController]
    public class ConsultaController : ControllerBase
    {
        /// <summary>
        /// Retorna lista de Consultas.
        /// </summary>
        /// <returns>Retorna uma lista das Consultas cadastradas.</returns>
        /// <response code="200">Retorno da lista de Consultas.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a consulta.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IEnumerable<Consulta> Listar()
        {
            return new List<Consulta> {
                new Consulta { Id = 1 },
                new Consulta { Id = 2 }
            };
        }

        /// <summary>
        /// Retorna uma Consulta.
        /// </summary>
        /// <param name="id">Representa o Id da Consulta</param>
        /// <returns>Retorna o resultado da Consulta consultada.</returns>
        /// <response code="200">Retorno da Consulta consultada.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a consulta.</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Consulta Consultar(int id)
        {
            return new Consulta { Id = 1 };
        }

        /// <summary>
        /// Cadastra uma Consulta.
        /// </summary>
        /// <returns>Retorna o resultado da Consulta cadastrada.</returns>
        /// <response code="200">Retorno da Consulta cadastrada.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a consulta.</response>
        [HttpPost]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Consulta Criar([FromBody] Consulta consulta)
        {
            return new Consulta { Id = 1 };
        }

        /// <summary>
        /// Atualiza uma Consulta.
        /// </summary>
        /// <param name="id">Representa o Id da Consulta</param>
        /// <returns>Retorna o resultado da Consulta atualizada.</returns>
        /// <response code="200">Retorno da Consulta atualizada.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a consulta.</response>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Consulta Atualizar(int id, [FromBody] Consulta consulta)
        {
            return new Consulta { Id = 1 };
        }

        /// <summary>
        /// Exclui uma Consulta.
        /// </summary>
        /// <param name="id">Representa o Id da Consulta</param>
        /// <response code="200">Consulta excluída com sucesso</response>
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
