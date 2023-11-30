using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Models 
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Adicione aqui as DbSet para seus modelos de dados
        // public DbSet<SeuModelo> NomeDoModelo { get; set; }
    }
}