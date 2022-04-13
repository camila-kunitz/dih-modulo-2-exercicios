using ClinicaVeterinaria.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaVeterinaria.Controllers
{
    [Route("api/veterinario")]
    [ApiController]
    public class VeterinarioController : ControllerBase
    {
        /// <summary>
        /// Retorna lista de Veterinarios.
        /// </summary>
        /// <returns>Retorna uma lista dos Veterinarios cadastrados.</returns>
        /// <response code="200">Retorno da lista de Veterinarios.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a consulta.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IEnumerable<Veterinario> Listar()
        {
            return new List<Veterinario> {
                new Veterinario { Id = 1 },
                new Veterinario { Id = 2 }
            };
        }

        /// <summary>
        /// Retorna um Veterinario.
        /// </summary>
        /// <param name="id">Representa o Id do Veterinario</param>
        /// <returns>Retorna o resultado do Veterinario consultado.</returns>
        /// <response code="200">Retorno do Veterinario consultado.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a consulta.</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Veterinario Consultar(int id)
        {
            return new Veterinario { Id = 1 };
        }

        /// <summary>
        /// Cadastra um Veterinario.
        /// </summary>
        /// <returns>Retorna o resultado do Veterinario cadastrado.</returns>
        /// <response code="200">Retorno do Veterinario cadastrado.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a consulta.</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Veterinario Criar([FromBody] Veterinario veterinario)
        {
            return new Veterinario { Id = 1 };
        }

        /// <summary>
        /// Atualiza um Veterinario.
        /// </summary>
        /// <param name="id">Representa o Id do Veterinario</param>
        /// <returns>Retorna o resultado do Veterinario atualizado.</returns>
        /// <response code="200">Retorno do Veterinario atualizado.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a consulta.</response>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Veterinario Atualizar(int id, [FromBody] Veterinario veterinario)
        {
            return new Veterinario { Id = 1 };
        }

        /// <summary>
        /// Exclui um Veterinario.
        /// </summary>
        /// <param name="id">Representa o Id do Veterinario</param>
        /// <response code="200">Veterinario excluído com sucesso</response>
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
