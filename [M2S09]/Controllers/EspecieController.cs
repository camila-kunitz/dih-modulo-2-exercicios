using ClinicaVeterinaria.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaVeterinaria.Controllers
{
    [Route("api/especie")]
    [ApiController]
    public class EspecieController : ControllerBase
    {
        /// <summary>
        /// Retorna lista de Espécies.
        /// </summary>
        /// <returns>Retorna uma lista das Espécies cadastradas.</returns>
        /// <response code="200">Retorno da lista de Espécies.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a Espécie.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IEnumerable<Especie> Listar()
        {
            return new List<Especie> {
                new Especie { Id = 1 },
                new Especie { Id = 2 }
            };
        }

        /// <summary>
        /// Retorna uma Espécie.
        /// </summary>
        /// <param name="id">Representa o Id da Espécie</param>
        /// <returns>Retorna o resultado da Espécie Espécieda.</returns>
        /// <response code="200">Retorno da Espécie Espécieda.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a Espécie.</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Especie Espécier(int id)
        {
            return new Especie { Id = 1 };
        }

        /// <summary>
        /// Cadastra uma Espécie.
        /// </summary>
        /// <returns>Retorna o resultado da Espécie cadastrada.</returns>
        /// <response code="200">Retorno da Espécie cadastrada.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a Espécie.</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Especie Criar([FromBody] Especie especie)
        {
            return new Especie { Id = 1 };
        }

        /// <summary>
        /// Atualiza uma Espécie.
        /// </summary>
        /// <param name="id">Representa o Id da Espécie</param>
        /// <returns>Retorna o resultado da Espécie atualizada.</returns>
        /// <response code="200">Retorno da Espécie atualizada.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a Espécie.</response>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Especie Atualizar(int id, [FromBody] Especie especie)
        {
            return new Especie { Id = 1 };
        }

        /// <summary>
        /// Exclui uma Espécie.
        /// </summary>
        /// <param name="id">Representa o Id da Espécie</param>
        /// <response code="200">Espécie excluída com sucesso</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a Espécie.</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public void Deletar(int id)
        {
        }
    }
}
