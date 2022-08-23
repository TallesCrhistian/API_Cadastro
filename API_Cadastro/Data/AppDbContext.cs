using API_Cadastro.Data.Config;
using API_Cadastro.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Cadastro.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PessoaConfiguration());
        }


        public DbSet<Pessoa> Pessoas { get; set; }
       
    }
}
