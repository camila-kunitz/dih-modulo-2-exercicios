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
    [Route("api/v{version:apiVersion}/exame")]
    [ApiVersion("1.0")]
    [ApiController]
    public class ExameController : ControllerBase
    {
        private readonly ClinicaVeterinariaContext _context;

        public ExameController(ClinicaVeterinariaContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Consulta lista de Exames.
        /// </summary>
        /// <returns>Retorna uma lista dos Exames cadastrados.</returns>
        /// <response code="200">Retorno da lista de Exames.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a consulta.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<Exame>>> GetExames()
        {
            return await _context.Exames.ToListAsync();
        }

        /// <summary>
        /// Consulta um Exame por Id.
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
        public async Task<ActionResult<Exame>> GetExame(int id)
        {
            var exame = await _context.Exames.FindAsync(id);

            if (exame == null)
            {
                return NotFound();
            }

            return exame;
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
        public async Task<IActionResult> PutExame(int id, Exame exame)
        {
            if (id != exame.Id)
            {
                return BadRequest();
            }

            _context.Entry(exame).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExameExists(id))
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
        public async Task<ActionResult<Exame>> PostExame(Exame exame)
        {
            _context.Exames.Add(exame);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExame", new { id = exame.Id }, exame);
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
        public async Task<IActionResult> DeleteExame(int id)
        {
            var exame = await _context.Exames.FindAsync(id);
            if (exame == null)
            {
                return NotFound();
            }

            _context.Exames.Remove(exame);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExameExists(int id)
        {
            return _context.Exames.Any(e => e.Id == id);
        }
    }
}
