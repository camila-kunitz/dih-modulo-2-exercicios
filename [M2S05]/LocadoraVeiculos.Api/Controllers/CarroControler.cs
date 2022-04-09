using LocadoraVeiculos.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraVeiculos.Api.Controllers;

[ApiController]
[Route("/api/carro")]
public class CarroControler : Controller
{
    [HttpGet("{id}")]
    public Carro GetCarro(int id)
    {
        return new Carro("Corolla", "Toyota", "XXX-0000", 10000, 5, true);
    }
    
    [HttpGet]
    public List<Carro> GetCarros()
    {
        return new List<Carro>
        {
            new Carro("Corolla", "Toyota", "XXX-0000", 10000, 5, true),
            new Carro("Hilux", "Toyota", "XXX-1111", 20000, 5, true),
            new Carro("Yaris", "Toyota", "XXX-2222", 30000, 5, true),
        };
    }
}