using Escola.Dominio.ProfessorModule;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Escola.Infra.ORM.Configurations.ProfessorModule
{
    public class ProfessorConfiguration : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.ToTable("TBProfessores");

            builder.HasKey(a => a.Id);

            builder.Property(p => p.Nome).HasColumnType("VARCHAR(80)").IsRequired();

            builder.Property(p => p.Endereco).HasColumnType("VARCHAR(80)").IsRequired();

            builder.Property(p => p.DataNascimento).HasColumnType("SMALLDATETIME").IsRequired();

            builder.Property(p => p.Idade).HasColumnType("INT").IsRequired();
        }
    }
}
