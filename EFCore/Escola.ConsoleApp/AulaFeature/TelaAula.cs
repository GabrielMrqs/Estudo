using Escola.Infra.ORM.Features.ProfessorModule;
using Escola.Infra.ORM.Features.AlunoModule;
using Escola.Infra.ORM.Features.AulaModule;
using Escola.Dominio.ProfessorModule;
using Escola.Dominio.AlunoModule;
using Escola.Dominio.AulaModule;
using System;
using Escola.Infra.ORM.Contexts;
using System.Linq;

namespace Escola.ConsoleApp.AulaFeature
{
    public class TelaAula
    {
        readonly AlunoORM alunoORM;
        readonly ProfessorORM professorORM;
        readonly AulaORM aulaORM;
        public TelaAula()
        {
            AulaContext aula = new();
            alunoORM = new(aula);
            professorORM = new(aula);
            aulaORM = new(aula);
            Inserir();
        }

        private void Inserir()
        {
            Console.Clear();

            Console.Write("Insira o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Insira a descrição: ");
            string descricao = Console.ReadLine();

            ExibirAlunos();

            Console.Write("\nInsira o ID do Aluno: ");
            int idAluno = Convert.ToInt32(Console.ReadLine());

            Aluno aluno = alunoORM.GetById(idAluno);

            ExibirProfessores();

            Console.Write("\nInsira o ID do Professor: ");
            int idProfessor = Convert.ToInt32(Console.ReadLine());

            Professor professor = professorORM.GetById(idProfessor);

            Aula aula = new(nome, descricao, aluno, professor);

            aulaORM.Inserir(aula);

        }

        private void ExibirProfessores()
        {
            Console.WriteLine();
            professorORM.GetAll().ToList().ForEach(x => Console.WriteLine(x));
        }

        private void ExibirAlunos()
        {
            Console.WriteLine();
            alunoORM.GetAll().ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
