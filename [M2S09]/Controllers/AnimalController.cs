using ClinicaVeterinaria.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaVeterinaria.Controllers
{
    [Route("api/animal")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        /// <summary>
        /// Retorna lista de Animais.
        /// </summary>
        /// <returns>Retorna uma lista dos animais cadastrados.</returns>
        /// <response code="200">Retorno da lista de Animais.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a consulta.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IEnumerable<Animal> Listar()
        {
            return new List<Animal> { 
                new Animal { Id = 1, Nome= "Nino", Idade = 1, Sexo = "M" },
                new Animal { Id = 2, Nome= "Lulu", Idade = 2, Sexo = "F" },
            };
        }

        /// <summary>
        /// Retorna um Animal.
        /// </summary>
        /// <param name="id">Representa o Id do Animal</param>
        /// <returns>Retorna o resultado do Animal consultado.</returns>
        /// <response code="200">Retorno do Animal consultado.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a consulta.</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Animal Consultar(int id)
        {
            var cliente = new Cliente { Id = 1, Nome = "Ana", Endereco = "Rua alfabeto", Bairro = "X", CEP = "88351-270", Cidade = "Rio", Estado = "RJ", Telefone = "5548996038150" };
            var especie = new Especie { Id = 1, Descricao = "Gato" };
            var animal = new Animal { Id = id, Nome = "Nino", Idade = 1, Sexo = "M", Cliente = cliente, Especie = especie };

            return animal;
        }

        /// <summary>
        /// Cadastra um Animal.
        /// </summary>
        /// <returns>Retorna o resultado do Animal cadastrado.</returns>
        /// <response code="200">Retorno do Animal cadastrado.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a consulta.</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Animal Criar([FromBody] Animal animal)
        {
            return new Animal { Id = 3, Nome = "Nino", Idade = 1, Sexo = "M" };
        }

        /// <summary>
        /// Atualiza um Animal.
        /// </summary>
        /// <param name="id">Representa o Id do Animal</param>
        /// <returns>Retorna o resultado do Animal atualizado.</returns>
        /// <response code="200">Retorno do Animal atualizado.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a consulta.</response>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public Animal Atualizar(int id, [FromBody] Animal animal)
        {
            return new Animal { Id = 4, Nome = "Nino", Idade = 1, Sexo = "M" };
        }

        /// <summary>
        /// Exclui um Animal.
        /// </summary>
        /// <param name="id">Representa o Id do Animal</param>
        /// <response code="200">Animal excluído com sucesso</response>
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
