using Microsoft.EntityFrameworkCore;
using WebApiUser.Models;

namespace WebApiUser.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<AuditoriaModel> Auditorias { get; set; }
    }
}