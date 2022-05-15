using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Veiculos.API.Context;
using Veiculos.API.Models;

namespace Veiculos.API.Controllers
{
    [Route("api/cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly VeiculosContext _context;

        public ClienteController(VeiculosContext context)
        {
            _context = context;
        }
         
        [HttpGet]
        public ICollection<Cliente> ConsultarClientes()
        {
            return _context.Cliente.ToList();
        }

        [HttpPost]
        public void CriarCliente([FromBody] Cliente novoCliente)
        {
            _context.Cliente.Add(novoCliente);
            _context.SaveChanges();
        }

        [HttpPut("{id}")]
        public void AtualizarCliente(int id, Cliente cliente)
        {
            _context.Entry(cliente).State = EntityState.Modified;
            _context.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void DeletarCliente(int id)
        {
            var cliente = _context.Cliente.Find(id);
            _context.Cliente.Remove(cliente);
            _context.SaveChangesAsync();
        }
    }
}
