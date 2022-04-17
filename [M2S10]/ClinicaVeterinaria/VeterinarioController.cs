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
    [Route("api/v{version:apiVersion}/veterinario")]
    [ApiVersion("1.0")]
    [ApiController]
    public class VeterinarioController : ControllerBase
    {
        private readonly ClinicaVeterinariaContext _context;

        public VeterinarioController(ClinicaVeterinariaContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Consulta lista de Veterinarios.
        /// </summary>
        /// <returns>Retorna uma lista dos Veterinarios cadastrados.</returns>
        /// <response code="200">Retorno da lista de Veterinarios.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a consulta.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<Veterinario>>> GetVeterinarios()
        {
            return await _context.Veterinarios.ToListAsync();
        }

        /// <summary>
        /// Consulta um Veterinario por Id.
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
        public async Task<ActionResult<Veterinario>> GetVeterinario(int id)
        {
            var veterinario = await _context.Veterinarios.FindAsync(id);

            if (veterinario == null)
            {
                return NotFound();
            }

            return veterinario;
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
        public async Task<IActionResult> PutVeterinario(int id, Veterinario veterinario)
        {
            if (id != veterinario.Id)
            {
                return BadRequest();
            }

            _context.Entry(veterinario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VeterinarioExists(id))
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
        public async Task<ActionResult<Veterinario>> PostVeterinario(Veterinario veterinario)
        {
            _context.Veterinarios.Add(veterinario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVeterinario", new { id = veterinario.Id }, veterinario);
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
        public async Task<IActionResult> DeleteVeterinario(int id)
        {
            var veterinario = await _context.Veterinarios.FindAsync(id);
            if (veterinario == null)
            {
                return NotFound();
            }

            _context.Veterinarios.Remove(veterinario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VeterinarioExists(int id)
        {
            return _context.Veterinarios.Any(e => e.Id == id);
        }
    }
}
