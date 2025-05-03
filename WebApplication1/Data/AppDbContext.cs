using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TemperaturaSensor> Temperaturas { get; set; }
        public DbSet<TensaoCell> Tensoes { get; set; }

    }
}
