using ClinicaVeterinaria.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaVeterinaria.Controllers
{
    [Route("api/exame")]
    [ApiController]
    public class ExameController : ControllerBase
    {
        /// <summary>
        /// Retorna lista de Exames.
        /// </summary>
        /// <returns>Retorna uma lista dos Exames cadastrados.</returns>
        /// <response code="200">Retorno da lista de Exames.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a consulta.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IEnumerable<Exame> Listar()
        {
            return new List<Exame> {
                new Exame { Id = 1 },
                new Exame { Id = 2 }
            };
        }

        /// <summary>
        /// Retorna um Exame.
        /// </summary>
        /// <param name="id">Representa o Id do Exame</param>
        /// <returns>Retorna o resultado do Exame consultado.</returns>
        /// <response code="200">Retorno do Exame consultado.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a consulta.</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Exame Consultar(int id)
        {
            return new Exame { Id = 1 };
        }

        /// <summary>
        /// Cadastra um Exame.
        /// </summary>
        /// <returns>Retorna o resultado do Exame cadastrado.</returns>
        /// <response code="200">Retorno do Exame cadastrado.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a consulta.</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Exame Criar([FromBody] Exame exame)
        {
            return new Exame { Id = 1 };
        }

        /// <summary>
        /// Atualiza um Exame.
        /// </summary>
        /// <param name="id">Representa o Id do Exame</param>
        /// <returns>Retorna o resultado do Exame atualizado.</returns>
        /// <response code="200">Retorno do Exame atualizado.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a consulta.</response>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Exame Atualizar(int id, [FromBody] Exame exame)
        {
            return new Exame { Id = 1 };
        }

        /// <summary>
        /// Exclui um Exame.
        /// </summary>
        /// <param name="id">Representa o Id do Exame</param>
        /// <response code="200">Exame excluído com sucesso</response>
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
