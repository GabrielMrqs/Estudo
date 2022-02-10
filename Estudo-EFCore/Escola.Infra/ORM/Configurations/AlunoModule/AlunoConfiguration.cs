using Escola.Dominio.AlunoModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Escola.Infra.ORM.Configurations.AlunoModule
{
    public class AlunoConfiguration : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("TBAlunos");

            builder.HasKey(a => a.Id);

            builder.Property(p => p.Nome).HasColumnType("VARCHAR(80)").IsRequired();

            builder.Property(p => p.Endereco).HasColumnType("VARCHAR(80)").IsRequired(); 

            builder.Property(p => p.DataNascimento).HasColumnType("SMALLDATETIME").IsRequired();

            builder.Property(p => p.Idade).HasColumnType("INT").IsRequired();                
        }
    }
}
