using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TemperaturasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TemperaturasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult PostTemperatura([FromBody] TemperaturaSensor temperatura)
        {
            _context.Temperaturas.Add(temperatura);
            _context.SaveChanges();
            return Ok(temperatura);
        }

        [HttpGet]
        public IActionResult GetTemperaturas()
        {
            var lista = _context.Temperaturas.ToList();
            return Ok(lista);
        }
    }
}
