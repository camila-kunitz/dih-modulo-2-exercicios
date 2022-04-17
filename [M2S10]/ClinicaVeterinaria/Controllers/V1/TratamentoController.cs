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
    [Route("api/v{version:apiVersion}/tratamento")]
    [ApiVersion("1.0")]
    [ApiController]
    public class TratamentoController : ControllerBase
    {
        private readonly ClinicaVeterinariaContext _context;

        public TratamentoController(ClinicaVeterinariaContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Consulta lista de Tratamentos.
        /// </summary>
        /// <returns>Retorna uma lista dos Tratamentos cadastrados.</returns>
        /// <response code="200">Retorno da lista de Tratamentos.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a consulta.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<Tratamento>>> GetTratamentos()
        {
            return await _context.Tratamentos.ToListAsync();
        }

        /// <summary>
        /// Consulta um Tratamento por Id.
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
        public async Task<ActionResult<Tratamento>> GetTratamento(int id)
        {
            var tratamento = await _context.Tratamentos.FindAsync(id);

            if (tratamento == null)
            {
                return NotFound();
            }

            return tratamento;
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
        public async Task<IActionResult> PutTratamento(int id, Tratamento tratamento)
        {
            if (id != tratamento.Id)
            {
                return BadRequest();
            }

            _context.Entry(tratamento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TratamentoExists(id))
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
        public async Task<ActionResult<Tratamento>> PostTratamento(Tratamento tratamento)
        {
            _context.Tratamentos.Add(tratamento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTratamento", new { id = tratamento.Id }, tratamento);
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
        public async Task<IActionResult> DeleteTratamento(int id)
        {
            var tratamento = await _context.Tratamentos.FindAsync(id);
            if (tratamento == null)
            {
                return NotFound();
            }

            _context.Tratamentos.Remove(tratamento);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TratamentoExists(int id)
        {
            return _context.Tratamentos.Any(e => e.Id == id);
        }
    }
}
