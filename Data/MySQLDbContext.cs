using proyectoNuevo.Models;
using Microsoft.EntityFrameworkCore;

namespace proyectoNuevo.Data
{
    public class MySQLDbContext : DbContext
    {
        public MySQLDbContext(
            DbContextOptions<MySQLDbContext> options) : base(options) { }

        public DbSet<Item> Items { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
