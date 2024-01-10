using MercuryViagens.Database;
using MercuryViagens.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MercuryViagens.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacoteViagemController : ControllerBase
    {
        private readonly MyDbContext _db;

        public PacoteViagemController(MyDbContext context)
        {
            _db = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<PacoteViagem>>> GetAll()
        {
            var pacotes = await _db.PacotesViagens
                .OrderByDescending(pacote => pacote.Id)
                .Include(pacote => pacote.Destino)
                .ThenInclude(destino => destino.Imagens)
                .ToListAsync();

            return Ok(pacotes);
        }
    }
}
