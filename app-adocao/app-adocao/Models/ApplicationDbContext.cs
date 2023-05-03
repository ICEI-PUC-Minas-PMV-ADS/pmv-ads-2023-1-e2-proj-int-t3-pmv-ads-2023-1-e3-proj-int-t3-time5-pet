using Microsoft.EntityFrameworkCore;

namespace app_adocao.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Responsavel> Responsaveis { get; set;}
        public DbSet<Requerente> Requerentes { get; set;}
        public DbSet<Pet> Pets { get; set;}
        public DbSet<Adocao> Adocoes { get; set;}
    }
}
