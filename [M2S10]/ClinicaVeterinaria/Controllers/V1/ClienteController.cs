using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClinicaVeterinaria.Context;
using ClinicaVeterinaria.Models;

namespace ClinicaVeterinaria
{
    [Route("api/v{version:apiVersion}/cliente")]
    [ApiVersion("1.0")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ClinicaVeterinariaContext _context;

        public ClienteController(ClinicaVeterinariaContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Consulta lista de Clientes.
        /// </summary>
        /// <returns>Retorna uma lista dos clientes cadastrados.</returns>
        /// <response code="200">Retorno da lista de Clientes.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a consulta.</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
        {
            return await _context.Clientes.ToListAsync();
        }

        /// <summary>
        /// Consulta um Cliente por Id.
        /// </summary>
        /// <param name="id">Representa o Id do Cliente</param>
        /// <returns>Retorna o resultado do Cliente consultado.</returns>
        /// <response code="200">Retorno do Cliente consultado.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a consulta.</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Cliente>> GetCliente(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return cliente;
        }

        /// <summary>
        /// Retorna um Cliente.
        /// </summary>
        /// <param name="id">Representa o Id do Cliente</param>
        /// <returns>Retorna o resultado do Cliente consultado.</returns>
        /// <response code="200">Retorno do Cliente consultado.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a consulta.</response>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PutCliente(int id, Cliente cliente)
        {
            if (id != cliente.Id)
            {
                return BadRequest();
            }

            _context.Entry(cliente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClienteExists(id))
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
        /// Cadastra um Cliente.
        /// </summary>
        /// <returns>Retorna o resultado do Cliente cadastrado.</returns>
        /// <response code="200">Retorno do Cliente cadastrado.</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a consulta.</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Cliente>> PostCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCliente", new { id = cliente.Id }, cliente);
        }

        /// <summary>
        /// Exclui um Cliente.
        /// </summary>
        /// <param name="id">Representa o Id do Cliente</param>
        /// <response code="200">Cliente excluído com sucesso</response>
        /// <response code="404">Não encontrado.</response>
        /// <response code="200">Ocorreu uma exceção durante a consulta.</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteCliente(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }

            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClienteExists(int id)
        {
            return _context.Clientes.Any(e => e.Id == id);
        }
    }
}
