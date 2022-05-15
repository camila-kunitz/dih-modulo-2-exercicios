using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Veiculos.API.Context;
using Veiculos.API.Models;

namespace Veiculos.API.Controllers
{
    [Route("api/veiculo")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        private readonly VeiculosContext _context;

        public VeiculoController(VeiculosContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ICollection<Veiculo> ConsultarVeiculos()
        {
            return _context.Veiculos.ToList();
        }

        [HttpPost]
        public void CriarVeiculo([FromBody] Veiculo novoVeiculo)
        {
            _context.Veiculos.Add(novoVeiculo);
            _context.SaveChanges();
        }

        [HttpPut("{id}")]
        public void AtualizarVeiculo(int id, Veiculo veiculo)
        {
            _context.Entry(veiculo).State = EntityState.Modified;
            _context.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void DeletarVeiculo(int id)
        {
            var veiculo = _context.Veiculos.Find(id);
            _context.Veiculos.Remove(veiculo);
            _context.SaveChangesAsync();
        }
    }
}
