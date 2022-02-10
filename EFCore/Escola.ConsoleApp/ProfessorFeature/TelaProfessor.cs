using Escola.Dominio.ProfessorModule;
using Escola.Infra.ORM.Contexts;
using Escola.Infra.ORM.Features.ProfessorModule;
using System;

namespace Escola.ConsoleApp.ProfessorFeature
{
    public class TelaProfessor
    {
        readonly ProfessorORM professorORM;
        public TelaProfessor()
        {
            AulaContext aula = new();
            professorORM = new(aula);
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

            Professor professor = new(nome, endereco, dataNascimento, idade);

            professorORM.Inserir(professor);
        }
    }
}
