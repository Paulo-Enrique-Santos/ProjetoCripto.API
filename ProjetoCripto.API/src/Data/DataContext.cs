using Microsoft.EntityFrameworkCore;
using ProjetoCripto.API.src.Models;

namespace ProjetoCripto.API.src.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Usuarios { get; set; }
    }
}
