using Escola.Dominio.AlunoModule;
using Escola.Dominio.ProfessorModule;
using Escola.Dominio.Shared;

namespace Escola.Dominio.AulaModule
{
    public class Aula : EntidadeBase
    {
        public int IdAluno { get; set; }
        public Aluno Aluno { get; set; }
        public int IdProfessor { get; set; }
        public Professor Professor { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Aula()
        {

        }
        public Aula(string nome, string descricao, Aluno aluno, Professor professor)
        {
            Nome = nome;
            Descricao = descricao;
            Aluno = aluno;
            Professor = professor;
        }
    }
}
