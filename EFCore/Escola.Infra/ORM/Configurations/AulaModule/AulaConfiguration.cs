using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Escola.Dominio.AulaModule;

namespace Escola.Infra.ORM.Configurations
{
    public class AulaConfiguration : IEntityTypeConfiguration<Aula>
    {
        public void Configure(EntityTypeBuilder<Aula> builder)
        {
            builder.ToTable("TBAulas");

            builder.HasKey(a => new { a.IdAluno, a.IdProfessor });

            builder.HasOne(a => a.Aluno)
                   .WithMany(a => a.Aulas)
                   .HasForeignKey(a => a.IdAluno);

            builder.HasOne(a => a.Professor)
                   .WithMany(a => a.Aulas)
                   .HasForeignKey(a => a.IdProfessor);
        }
    }
}
