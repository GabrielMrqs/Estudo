using Escola.Dominio.ProfessorModule;
using Microsoft.EntityFrameworkCore;
using Escola.Dominio.AlunoModule;
using Escola.Dominio.AulaModule;

namespace Escola.Infra.ORM.Contexts
{
    public class AulaContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Aula> Aulas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=teste;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AulaContext).Assembly);
        }
    }
}
