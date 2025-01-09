using Microsoft.EntityFrameworkCore;

namespace Uxcomex.Models
{
    public class BancoDeDados: DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=Uxcomex;Integrated Security=True");
        }
    }
}
