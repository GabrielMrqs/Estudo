using Escola.Dominio.AlunoModule;
using Escola.Infra.ORM.Contexts;
using Escola.Infra.ORM.Features.AlunoModule;
using System;

namespace Escola.ConsoleApp.AlunoFeature
{
    public class TelaAluno
    {
        readonly AlunoORM alunoORM;
        public TelaAluno()
        {
            AulaContext aula = new();
            alunoORM = new(aula);
            Inserir();
        }
        public void Inserir()
        {
            Console.Clear();

            Console.Write("Insira o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Insira o endereço: ");
            string endereco = Console.ReadLine();

            Console.Write("Insira a data de nascimento: ");
            DateTime dataNascimento = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Insira a idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Aluno aluno = new (nome, endereco, dataNascimento, idade);

            alunoORM.Inserir(aluno);

        }
    }
}
