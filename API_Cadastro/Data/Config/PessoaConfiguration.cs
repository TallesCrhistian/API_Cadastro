using API_Cadastro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_Cadastro.Data.Config
{
    public class PessoaConfiguration : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder
                .ToTable("Pessoas");

            builder
                .Property(p => p.Id)
                .IsRequired()
                .HasColumnName("Id");

            builder
               .Property(p => p.Nome)
               .HasColumnName("nome")
               .HasColumnType("varchar(45)")
               .IsRequired();

            builder
               .Property(p => p.Cpf)
               .HasColumnName("cpf")
               .HasColumnType("varchar(14)")
               .IsRequired();

            builder
               .Property(p => p.Email)
               .HasColumnName("email")
               .HasColumnType("varchar(40)")
               .IsRequired();

            builder
               .Property(p => p.Telefone)
               .HasColumnName("telefone")
               .HasColumnType("varchar(15)")
               .IsRequired();

            
        }
    }
}
