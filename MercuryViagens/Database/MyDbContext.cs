using MercuryViagens.Models;
using Microsoft.EntityFrameworkCore;

namespace MercuryViagens.Database
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        public DbSet<Destino> Destinos { get; set; }

        public DbSet<PacoteViagem> PacotesViagens { get; set; }

        public DbSet<Imagem> Imagens { get; set; }
    }
}
