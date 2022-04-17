#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClinicaVeterinaria.Context;
using ClinicaVeterinaria.Models;

namespace ClinicaVeterinaria
{
    [Route("api/v{version:apiVersion}/especie")]
    [ApiVersion("1.0")]
    [ApiController]
    public class EspecieController : ControllerBase
    {
        private readonly ClinicaVeterinariaContext _context;

        public EspecieController(ClinicaVeterinariaContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Consulta lista de Espécies.
        /// </summary>
        /// <returns>Retorna uma lista das Espécies cadastradas.</returns>
        /// <response code="200">Retorno da lista de Espécies.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a Espécie.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<Especie>>> GetEspecies()
        {
            return await _context.Especies.ToListAsync();
        }

        /// <summary>
        /// Consulta uma Espécie por Id.
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
        public async Task<ActionResult<Especie>> GetEspecie(int id)
        {
            var especie = await _context.Especies.FindAsync(id);

            if (especie == null)
            {
                return NotFound();
            }

            return especie;
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
        public async Task<IActionResult> PutEspecie(int id, Especie especie)
        {
            if (id != especie.Id)
            {
                return BadRequest();
            }

            _context.Entry(especie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EspecieExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
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
        public async Task<ActionResult<Especie>> PostEspecie(Especie especie)
        {
            _context.Especies.Add(especie);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEspecie", new { id = especie.Id }, especie);
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
        public async Task<IActionResult> DeleteEspecie(int id)
        {
            var especie = await _context.Especies.FindAsync(id);
            if (especie == null)
            {
                return NotFound();
            }

            _context.Especies.Remove(especie);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EspecieExists(int id)
        {
            return _context.Especies.Any(e => e.Id == id);
        }
    }
}
