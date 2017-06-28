using ApiLivros.Models;
using Microsoft.EntityFrameworkCore;
namespace ApiLivros.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Livro> Livros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livro>().HasKey(c => c.ISBN);
        }
    }
}
