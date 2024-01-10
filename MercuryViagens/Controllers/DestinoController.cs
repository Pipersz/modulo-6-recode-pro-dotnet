using MercuryViagens.Database;
using MercuryViagens.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MercuryViagens.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinoController : ControllerBase
    {
        private MyDbContext _db;

        public DestinoController(MyDbContext context)
        {
            _db = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Destino>>> GetAll()
        {
            var destinos = await _db.Destinos.Include(destino => destino.Imagens).ToListAsync();

            return Ok(destinos);
        }
    }
}
