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

      

        public DbSet<Pessoa> Pessoas { get; set; }
       
    }
}
