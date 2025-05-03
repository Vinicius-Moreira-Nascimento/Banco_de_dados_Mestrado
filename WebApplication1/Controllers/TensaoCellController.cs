using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TensaoCellController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TensaoCellController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Post(TensaoCell tensao)
        {
            _context.Tensoes.Add(tensao);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Post), new { id = tensao.Id }, tensao);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var lista = _context.Tensoes.OrderByDescending(t => t.DataHora).ToList();
            return Ok(lista);
        }
    }
}
